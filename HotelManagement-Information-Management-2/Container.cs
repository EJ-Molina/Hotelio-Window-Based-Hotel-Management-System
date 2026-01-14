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
    public partial class Container : Form
    {
        //gen
        private string _role;
        private int _userId;
        private string _username;
        public Container(int userId, string username, string role)
        {
            InitializeComponent();
            _userId = userId;
            _username = username;
            _role = role.ToLower().Trim();
            //admin or tenant
            defineAccess();

        }

        public void loadForm(Form form)
        {
             panel3.Controls.Clear();          
             form.TopLevel = false;          
             form.FormBorderStyle = FormBorderStyle.None; 
             form.Dock = DockStyle.Fill;      
             panel3.Controls.Add(form);
             panel3.Tag = form;
             form.BringToFront();              
             form.Show();
        }

        public void defineAccess()
        {
            if (_role == "tenant")
            {
                guestBtn.Visible = false;
                bookingBtn.Visible = false;
                housekeepingBtn.Visible = false; // Hide from tenants
            }
        }
        private void housekeepingBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Housekeeping());
        }
        private void housekeepingBtn_Click_1(object sender, EventArgs e)
        {
            loadForm(new Housekeeping());
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard(_userId, _role));
        }

       
        private void guestBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Guest());
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            
            loadForm(new Rooms(_userId, _role));
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Schedules());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
