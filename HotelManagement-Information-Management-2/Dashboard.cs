using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagement_Information_Management_2
{
    public partial class Dashboard : Form
    {
        private string _role;
        private int _userId;
        private string conString = "server=localhost;username=root;password=;database=im_etr";

        public Dashboard(int userId, string role)
        {
            InitializeComponent();
            _userId = userId;
            _role = role.ToLower().Trim();
            numRooms.Text = getTotalRooms().ToString();
            numAvail.Text = getAvailableRooms().ToString();
            numPending.Text = getPendingBookings().ToString();
            defineAccess();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            defineAccess();

        }
        public void defineAccess()
        {
            if (_role == "tenant")
            {
                //numRooms.Text
                numCheckInPanel.Visible = false;
                numPendingPanel.Visible = false;
                addUserBtn.Visible = false;
                addUserBtn.Enabled = false;
            }

        }

        public int getPendingBookings()
        {
            int count = 0;
            string sql = "SELECT COUNT(*) FROM bookings WHERE status = 'Pending'";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return count;
        }

        public int getTotalRooms()
        {
            int count = 0;
            string sql = "SELECT COUNT(*) FROM rooms";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return count;
        }
        public int getAvailableRooms()
        {
            int count = 0;
            string sql = "SELECT COUNT(*) FROM rooms WHERE status = 'Available'";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return count;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            CreateAccount createForm = new CreateAccount();
            createForm.Show();
        }

        private void numCheckInPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numPendingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numGuestPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numRoomsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
