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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost;username=root;password=;database=im_etr";
            MySqlCommand cmd;
            MySqlConnection conn;
            string fullname = fullnameTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string contact = contactTxt.Text;
            string emergency = emergencyTxt.Text;
            try
            {
                using (conn = new MySqlConnection(conString))
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                      
                            string sqlUser = @"INSERT INTO users (username, password) 
                                   VALUES (@username, @password);
                                   SELECT LAST_INSERT_ID();";

                            int userId;

                            using (cmd = new MySqlCommand(sqlUser, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", password);

                                userId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                           
                            string sqlTenant = @"INSERT INTO tenants 
                            (full_name, contact_number, emergency_contact, user_id) 
                            VALUES (@fullname, @contact, @emergency, @user_id)";

                            using (cmd = new MySqlCommand(sqlTenant, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@fullname", fullname);
                                cmd.Parameters.AddWithValue("@contact", contact);
                                cmd.Parameters.AddWithValue("@emergency", emergency);
                                cmd.Parameters.AddWithValue("@user_id", userId);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show(
                                "Account created successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            this.Close();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) 
                {
                    MessageBox.Show(
                        "This username is already taken. Please choose a different one.",
                        "Duplicate Username",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Database error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void dad_Click(object sender, EventArgs e)
        {

        }
    }
}
