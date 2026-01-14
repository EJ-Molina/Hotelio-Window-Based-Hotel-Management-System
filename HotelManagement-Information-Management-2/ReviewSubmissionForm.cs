using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagement_Information_Management_2
{
    public partial class ReviewSubmissionForm : Form
    {
        private int _roomId;
        private int _userId;
        private string conString = "server=localhost;username=root;password=;database=im_etr";

        public ReviewSubmissionForm(int roomId, int userId, string roomNumber)
        {
            InitializeComponent();
            _roomId = roomId;
            _userId = userId;
            this.Text = "Rate Room " + roomNumber;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Please add a comment.");
                return;
            }

            string sql = "INSERT INTO room_reviews (room_id, user_id, rating, comment) VALUES (@rid, @uid, @rate, @comm)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@rid", _roomId);
                        cmd.Parameters.AddWithValue("@uid", _userId);
                        cmd.Parameters.AddWithValue("@rate", numRating.Value);
                        cmd.Parameters.AddWithValue("@comm", txtComment.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thank you for your feedback!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}