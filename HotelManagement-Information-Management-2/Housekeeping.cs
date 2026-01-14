using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagement_Information_Management_2
{
    public partial class Housekeeping : Form
    {
        private string conString = "server=localhost;username=root;password=;database=im_etr";

        public Housekeeping()
        {
            InitializeComponent();
            SetupGrid();
            LoadHousekeepingData();
            LoadRoomList();
        }

        private void SetupGrid()
        {
            dgvHousekeeping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHousekeeping.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHousekeeping.MultiSelect = false;
            dgvHousekeeping.AllowUserToAddRows = false;
            dgvHousekeeping.ReadOnly = true;
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                LoadRoomList(); // This ensures 'Dirty' rooms show up immediately
                LoadHousekeepingData();
            }
        }

        private void LoadHousekeepingData()
        {
            // JOIN is used to get the room_number from the rooms table based on room_id
            string sql = @"SELECT h.task_id, r.room_number, h.staff_name, h.cleaning_status, h.scheduled_date 
                           FROM housekeeping h 
                           JOIN rooms r ON h.room_id = r.room_id 
                           ORDER BY h.scheduled_date DESC";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHousekeeping.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading grid: " + ex.Message); }
        }

        private void LoadRoomList()
        {
            List<KeyValuePair<string, string>> rooms = new List<KeyValuePair<string, string>>();
            // Only rooms set to 'Dirty' in the database will show here
            string sql = "SELECT room_id, room_number FROM rooms WHERE status = 'Dirty'";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            rooms.Add(new KeyValuePair<string, string>(
                                dr["room_id"].ToString(),
                                dr["room_number"].ToString()
                            ));
                        }
                    }
                }

                roomCombo.DataSource = null;
                if (rooms.Count > 0)
                {
                    // Binding the list so 'Value' shows room number and 'Key' holds the ID
                    roomCombo.DataSource = new BindingSource(rooms, null);
                    roomCombo.DisplayMember = "Value";
                    roomCombo.ValueMember = "Key";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading rooms: " + ex.Message); }
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            // Ensure a room is selected and the Staff TextBox is not empty
            if (roomCombo.SelectedItem == null || string.IsNullOrWhiteSpace(staffNameTxt.Text))
            {
                MessageBox.Show("Please select a room and enter staff name.");
                return;
            }

            var selectedRoom = (KeyValuePair<string, string>)roomCombo.SelectedItem;
            string sql = "INSERT INTO housekeeping (room_id, staff_name, cleaning_status, scheduled_date) VALUES (@rid, @staff, 'Pending', NOW())";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@rid", selectedRoom.Key);
                        cmd.Parameters.AddWithValue("@staff", staffNameTxt.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Task Assigned!");
                staffNameTxt.Clear();
                LoadHousekeepingData(); // Refresh the list
                LoadRoomList();         // Refresh the dropdown
            }
            catch (Exception ex) { MessageBox.Show("Error assigning task: " + ex.Message); }
        }

        private void completeTaskBtn_Click(object sender, EventArgs e)
        {
            if (dgvHousekeeping.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(dgvHousekeeping.SelectedRows[0].Cells["task_id"].Value);
                string roomNum = dgvHousekeeping.SelectedRows[0].Cells["room_number"].Value.ToString();
                UpdateCleaningStatus(taskId, roomNum);
            }
        }

        private void UpdateCleaningStatus(int taskId, string roomNumber)
        {
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Mark task as Cleaned
                    string sqlTask = "UPDATE housekeeping SET cleaning_status = 'Cleaned' WHERE task_id = @tid";
                    new MySqlCommand(sqlTask, conn, trans) { Parameters = { new MySqlParameter("@tid", taskId) } }.ExecuteNonQuery();

                    // 2. Mark room as Available
                    string sqlRoom = "UPDATE rooms SET status = 'Available' WHERE room_number = @rnum";
                    new MySqlCommand(sqlRoom, conn, trans) { Parameters = { new MySqlParameter("@rnum", roomNumber) } }.ExecuteNonQuery();

                    trans.Commit();
                    LoadHousekeepingData();
                    LoadRoomList();
                    MessageBox.Show("Room updated to Available.");
                }
                catch (Exception ex) { trans.Rollback(); MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void roomCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}