using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagement_Information_Management_2
{
    public partial class FeedbackManagerForm : Form
    {
        private string conString = "server=localhost;username=root;password=;database=im_etr";

        public FeedbackManagerForm()
        {
            InitializeComponent();
            LoadReviews();
        }

        private void LoadReviews()
        {
            string sql = @"SELECT r.review_id, rm.room_number, u.username, r.rating, r.comment, r.created_at 
                   FROM room_reviews r 
                   JOIN rooms rm ON r.room_id = rm.room_id 
                   JOIN users u ON r.user_id = u.user_id 
                   ORDER BY r.created_at DESC";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Assign the data
                    dgvReviews.DataSource = dt;

                    // --- FORMATTING THE COLUMNS ---
                    if (dgvReviews.Columns.Contains("comment"))
                    {
                        // 1. Make the comment column wide
                        dgvReviews.Columns["comment"].Width = 400;

                        // 2. Wrap the text so long comments don't stay on one line
                        dgvReviews.Columns["comment"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }

                    // 3. Auto-adjust row height to fit the wrapped text
                    dgvReviews.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    // 4. Hide the ID column
                    if (dgvReviews.Columns.Contains("review_id"))
                        dgvReviews.Columns["review_id"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading: " + ex.Message); }
        }

        // --- THE DELETE ACTION ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // If no row is clicked, exit
            if (dgvReviews.CurrentRow == null)
            {
                MessageBox.Show("Please select a review from the list first.");
                return;
            }

            // Get the ID of the selected review
            int reviewId = Convert.ToInt32(dgvReviews.CurrentRow.Cells["review_id"].Value);

            if (MessageBox.Show("Are you sure you want to delete this feedback?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM room_reviews WHERE review_id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", reviewId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Review deleted successfully.");
                    LoadReviews(); // Refresh the table
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting: " + ex.Message);
                }
            }
        }

        private void FeedbackManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}