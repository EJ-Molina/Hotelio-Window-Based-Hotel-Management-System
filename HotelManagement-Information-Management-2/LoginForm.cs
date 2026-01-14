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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
    

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void createAccBtn_Click(object sender, EventArgs e)
        {
            CreateAccount createForm = new CreateAccount();
            createForm.Show();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost;username=root;password=;database=im_etr";
            string sql;

            MySqlConnection conn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                using (conn = new MySqlConnection(conString))
                {
                    conn.Open();

                    sql = "SELECT user_id, username, role FROM users WHERE username = @username AND password = @password";

                    using (cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text);

                        using (dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    int userId = dr.GetInt32("user_id");
                                    string username = dr.GetString("username");
                                    string role = dr.GetString("role");

                                    Container container = new Container(userId, username, role);
                                    /*Container container = new Container(textBox1.Text);*/
                                    container.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Credential is not Found");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
