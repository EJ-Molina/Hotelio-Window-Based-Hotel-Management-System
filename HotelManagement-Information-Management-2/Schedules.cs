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
    public partial class Schedules : Form
    {
        public Schedules()
        {
            InitializeComponent();
            LoadHistoryTransactions();
        }
        public string conString = "server=localhost;username=root;password=;database=im_etr;AllowUserVariables=True;";
        
        private void Schedules_Load(object sender, EventArgs e)
        {
            //call me mother
            LoadHistoryTransactions();
        }
        public void LoadHistoryTransactions()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string sql = @"
            SELECT 
               t.tenant_id AS id,
                 t.full_name,
                t.contact_number,
                t.emergency_contact,
                b.check_in_date,
                    b.check_out_date
            FROM bookings b
            INNER JOIN tenants t ON b.tenant_id = t.tenant_id
            WHERE b.status = 'Completed'
               OR (b.status = 'Approved' AND CURDATE() > b.check_out_date)
            ORDER BY b.check_out_date DESC";

            MySqlConnection conn;
            MySqlCommand cmd;
            MySqlDataReader reader;

            try
            {
                using (conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (cmd = new MySqlCommand(sql, conn))
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string fullname = reader.GetString("full_name");
                            string contact = reader.GetString("contact_number");
                            string emergency = reader.GetString("emergency_contact");

                            DateTime checkIn = reader.GetDateTime("check_in_date");
                            DateTime checkOut = reader.GetDateTime("check_out_date");

                            dataGridView1.Rows.Add(
                                id,
                                fullname,
                                contact,
                                emergency,
                                checkIn.ToString("yyyy-MM-dd"),
                                checkOut.ToString("yyyy-MM-dd")
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
