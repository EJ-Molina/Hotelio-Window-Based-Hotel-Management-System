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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
            loadDataCheckIn();
            loadDataCheckOut();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            loadDataCheckIn();
            loadDataCheckOut();
        }

        public string conString = "server=localhost;username=root;password=;database=im_etr;AllowUserVariables=True;";

        //CHECK INNN
        public void loadDataCheckIn()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string sql = @"
                SELECT 
                    t.tenant_id,
                    t.full_name,
                    t.contact_number,
                    t.emergency_contact,
                    r.room_number,
                    b.check_in_date
                FROM bookings b
                INNER JOIN tenants t ON b.tenant_id = t.tenant_id
                INNER JOIN rooms r ON b.room_id = r.room_id
                WHERE b.status = 'Approved'
                AND CURDATE() BETWEEN b.check_in_date AND b.check_out_date
                ORDER BY b.check_in_date DESC";
            ;
            MySqlConnection conn;
            MySqlCommand cmd;
            MySqlDataReader myReader;

            try
            {
                using (conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (cmd = new MySqlCommand(sql, conn))
                    using (myReader = cmd.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            string fullname = myReader["full_name"].ToString();
                            string contact_number = myReader["contact_number"].ToString();
                            string emergency = myReader["emergency_contact"].ToString();
                            string room_number = myReader["room_number"].ToString();
                            string id = myReader["tenant_id"].ToString();
                            DateTime check_in = Convert.ToDateTime(myReader["check_in_date"]);
                            dataGridView1.Rows.Add(fullname, contact_number, emergency, room_number, check_in.ToString("yyyy-MM-dd"), id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }
        //CHECK OUTTT
        public void loadDataCheckOut()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            string sql = @"
               SELECT 
                    t.full_name,
                    t.contact_number,
                    t.emergency_contact,
                    r.room_number,
                    b.check_in_date,
                    b.check_out_date
                FROM bookings b
                INNER JOIN tenants t ON b.tenant_id = t.tenant_id
                INNER JOIN rooms r ON b.room_id = r.room_id
                WHERE b.status = 'Completed'
                OR (b.status = 'Approved' AND CURDATE() > b.check_out_date)
                ORDER BY b.check_out_date DESC;";
            
            MySqlConnection conn;
            MySqlCommand cmd;
            MySqlDataReader myReader;

            try
            {
                using (conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (cmd = new MySqlCommand(sql, conn))
                    using (myReader = cmd.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            string fullname = myReader["full_name"].ToString();
                            string contact_number = myReader["contact_number"].ToString();
                            string emergency = myReader["emergency_contact"].ToString();
                            string room_number = myReader["room_number"].ToString();
                            //string check_in = myReader["check_in_date"].ToString();
                            DateTime check_out = Convert.ToDateTime(myReader["check_out_date"]);
                            dataGridView2.Rows.Add(fullname, contact_number, emergency, room_number, check_out.ToString("yyyy-MM-dd"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        //int selectedTenantId = 0;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // selectedTenantId = Convert.ToInt32(row.Cells["tenant_id"].Value);

            fullnameTxt.Text = row.Cells[0].Value?.ToString();
            contactTxt.Text = row.Cells[1].Value?.ToString();
            emergencyTxt.Text = row.Cells[2].Value?.ToString();
            //passwordTxt.Text = "***";
            idTxt.Text = row.Cells[5].Value?.ToString();

         
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            fullnameTxt.Enabled = true;
            /*usernameTxt.Enabled = true;
            passwordTxt.Enabled = true;*/
            contactTxt.Enabled = true;
            emergencyTxt.Enabled = true;
            saveBtn.Enabled = true;
            saveBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Update tenants table
                        string sql1 = @"UPDATE tenants
                           SET full_name = @fullname,
                               contact_number = @contact,
                               emergency_contact = @emergency
                           WHERE tenant_id = @tenantId";

                        using (MySqlCommand cmd = new MySqlCommand(sql1, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@fullname", fullnameTxt.Text);
                            cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                            cmd.Parameters.AddWithValue("@emergency", emergencyTxt.Text);
                            cmd.Parameters.AddWithValue("@tenantId", idTxt.Text);
                            cmd.ExecuteNonQuery();
                        }

                        // Update users table 
                        /*string sql2 = @"UPDATE users
                           SET username = @username,
                               password = @password
                           WHERE user_id = @userId";

                        using (MySqlCommand cmd = new MySqlCommand(sql2, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                            cmd.Parameters.AddWithValue("@password", passwordTxt.Text);
                            cmd.Parameters.AddWithValue("@userId", idTxt.Text);
                            cmd.ExecuteNonQuery();
                        }*/

                        transaction.Commit(); 
                        MessageBox.Show("Update successful!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Undo lahat if one fails
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }

            fullnameTxt.Enabled = false;
            /*usernameTxt.Enabled = false;
            passwordTxt.Enabled = false;*/
            contactTxt.Enabled = false;
            emergencyTxt.Enabled = false;
            saveBtn.Enabled = false;
            saveBtn.Visible = false;

            idTxt.Clear();
            fullnameTxt.Clear();
            /*usernameTxt.Clear();
            passwordTxt.Clear();*/
            contactTxt.Clear();
            emergencyTxt.Clear();

            loadDataCheckIn();
            /* try
             {

                 string sql = @"
                 UPDATE tenants
                 SET full_name = @fullname,
                     contact_number = @contact,
                     emergency_contact = @emergency
                 WHERE tenant_id = @tenantId;

                 UPDATE users
                 SET username = @username,
                     password = @password
                 WHERE user_id = @userId;";
                 using (MySqlConnection conn = new MySqlConnection(conString))
                 {
                     conn.Open();
                     using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                     {
                         cmd.Parameters.AddWithValue("@fullname", fullnameTxt.Text);
                         cmd.Parameters.AddWithValue("@contact", contactTxt.Text);
                         cmd.Parameters.AddWithValue("@emergency", emergencyTxt.Text);
                         cmd.Parameters.AddWithValue("@tenantId", idTxt.Text);
                         cmd.ExecuteNonQuery();
                     }
                 }

                 //OTER TABLE
                 string sql2 = @"UPDATE users
                            SET username = @username,
                                password = @password
                            WHERE user_id = @userId";

                 using (MySqlCommand cmd = new MySqlCommand(sql2, conn, transaction))
                 {
                     cmd.Parameters.AddWithValue("@username", username);
                     cmd.Parameters.AddWithValue("@password", password);
                     cmd.Parameters.AddWithValue("@userId", userId);
                     cmd.ExecuteNonQuery();
                 }
                 MessageBox.Show("Tenant updated successfully");
             }
             catch(Exception ex)
             {
                 MessageBox.Show("Connection error: " + ex.Message);
             }
             */
        }

    }
}
