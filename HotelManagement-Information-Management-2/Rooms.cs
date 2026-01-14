using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace HotelManagement_Information_Management_2
{
    public partial class Rooms : Form
    {
        private string _role;
        private int _userId;
        private string conString = "server=localhost;username=root;password=;database=im_etr";

        public Rooms(int userId, string role)
        {
            InitializeComponent();
            _userId = userId;
            Console.WriteLine("USER IDDDDDD---" + _userId);
            _role = role.ToLower().Trim();
            LoadRoomStatuses();
            AttachRoomClickEvents();

        }

        // Attach click events to all room buttons
        private void AttachRoomClickEvents()
        {
            s101Btn.Click += (s, e) => RoomButton_Click("S-101");
            s102Btn.Click += (s, e) => RoomButton_Click("S-102");
            s103Btn.Click += (s, e) => RoomButton_Click("S-103");
            s104Btn.Click += (s, e) => RoomButton_Click("S-104");
            s105Btn.Click += (s, e) => RoomButton_Click("S-105");
            s106Btn.Click += (s, e) => RoomButton_Click("S-106");

            m101Btn.Click += (s, e) => RoomButton_Click("M-101");
            m102Btn.Click += (s, e) => RoomButton_Click("M-102");
            m103Btn.Click += (s, e) => RoomButton_Click("M-103");
            m104Btn.Click += (s, e) => RoomButton_Click("M-104");
            m105Btn.Click += (s, e) => RoomButton_Click("M-105");
            m106Btn.Click += (s, e) => RoomButton_Click("M-106");

            l101Btn.Click += (s, e) => RoomButton_Click("L-101");
            l102Btn.Click += (s, e) => RoomButton_Click("L-102");
            l103Btn.Click += (s, e) => RoomButton_Click("L-103");
            l104Btn.Click += (s, e) => RoomButton_Click("L-104");
            l105Btn.Click += (s, e) => RoomButton_Click("L-105");
            l106Btn.Click += (s, e) => RoomButton_Click("L-106");
        }

        // Load all room statuses and update button colors
        public void LoadRoomStatuses()
        {
            string sql = "SELECT room_number, status FROM rooms";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string roomNumber = dr.GetString("room_number");
                                string status = dr.GetString("status");
                                UpdateRoomButtonColor(roomNumber, status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room statuses: " + ex.Message);
            }
        }

        // Update button color based on room status   di nagana
        // Update button color based on room status
        private void UpdateRoomButtonColor(string roomNumber, string status)
        {
            FontAwesome.Sharp.IconButton btn = GetRoomButton(roomNumber);
            if (btn == null) return;

            // Setting standard properties for the border
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2; // Adjust thickness as needed

            switch (status.Trim())
            {
                case "Available":
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.DarkGreen; // Container border color
                    break;
                case "Occupied":
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.DarkRed; // Container border color
                    break;
                case "Maintenance":
                    btn.BackColor = Color.Purple;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.Indigo; // Container border color
                    break;
                case "Dirty": // NEW STATUS
                    btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.White;
                  
                    btn.Text += "\n(Needs Cleaning)";
                    btn.FlatAppearance.BorderColor = Color.DarkOrange;
                    break;
                default:
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = Color.Gray;
                    break;
            }
        }
        private FontAwesome.Sharp.IconButton GetRoomButton(string roomNumber)
        {
            // This matches the naming convention: "s101Btn"
            string btnName = roomNumber.ToLower().Replace("-", "") + "Btn";

            // 'true' allows searching through nested child containers (Panels, etc.)
            Control[] found = this.Controls.Find(btnName, true);

            if (found.Length > 0 && found[0] is FontAwesome.Sharp.IconButton)
            {
                return (FontAwesome.Sharp.IconButton)found[0];
            }
            return null;
        }

        // Get button by room number
        /* private FontAwesome.Sharp.IconButton GetRoomButton(string roomNumber)
         {
             string btnName = roomNumber.ToLower().Replace("-", "") + "Btn";

             foreach (Control ctrl in this.Controls)
             {
                 if (ctrl is FontAwesome.Sharp.IconButton && ctrl.Name.ToLower() == btnName)
                 {
                     return (FontAwesome.Sharp.IconButton)ctrl;
                 }
             }
             return null;
         }*/

        // Handle room button click
        private void RoomButton_Click(string roomNumber)
        {
            if (_role == "admin")
            {
                ShowAdminRoomDetails(roomNumber);
            }
            else if (_role == "tenant")
            {
                ShowTenantRoomDetails(roomNumber);
            }
        }

        // ============ ADMIN METHODS ============////////////////////////////////////////////////////

        private void ShowAdminRoomDetails(string roomNumber)
        {
            DataRow roomData = GetRoomDetails(roomNumber);
            if (roomData == null)
            {
                MessageBox.Show("Room not found in database.");
                return;
            }

            int roomId = Convert.ToInt32(roomData["room_id"]);
            string status = roomData["status"].ToString();
            int capacity = Convert.ToInt32(roomData["capacity"]);
            decimal rate = Convert.ToDecimal(roomData["rate"]);

            // Build message
            StringBuilder msg = new StringBuilder();
            msg.AppendLine($"Room: {roomNumber}");
            msg.AppendLine($"Capacity: {capacity} person(s)");
            msg.AppendLine($"Rate: ₱{rate:N2}");
            msg.AppendLine($"Status: {status}");
            msg.AppendLine("-------------------");

            // Check for current tenant (if occupied)
            if (status == "Occupied")
            {
                DataRow tenantData = GetCurrentTenantForRoom(roomId);
                if (tenantData != null)
                {
                    msg.AppendLine($"Current Tenant: {tenantData["full_name"]}");
                    msg.AppendLine($"Contact: {tenantData["contact_number"]}");
                    msg.AppendLine($"Check-in: {Convert.ToDateTime(tenantData["check_in_date"]):yyyy-MM-dd}");
                    msg.AppendLine($"Check-out: {Convert.ToDateTime(tenantData["check_out_date"]):yyyy-MM-dd}");
                    msg.AppendLine("-------------------");
                }
            }

            // Check for pending request
            DataRow pendingBooking = GetPendingBookingForRoom(roomId);
            if (pendingBooking != null)
            {
                msg.AppendLine("PENDING REQUEST:");
                msg.AppendLine($"Tenant: {pendingBooking["full_name"]}");
                msg.AppendLine($"Contact: {pendingBooking["contact_number"]}");
                msg.AppendLine($"Requested Check-in: {Convert.ToDateTime(pendingBooking["check_in_date"]):yyyy-MM-dd}");
                msg.AppendLine($"Requested Check-out: {Convert.ToDateTime(pendingBooking["check_out_date"]):yyyy-MM-dd}");
                msg.AppendLine("-------------------");
                msg.AppendLine("Do you want to APPROVE this request?");

                DialogResult result = MessageBox.Show(msg.ToString(), "Room Details - Pending Request",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                int bookingId = Convert.ToInt32(pendingBooking["booking_id"]);

                if (result == DialogResult.Yes)
                {
                    ApproveBooking(bookingId, roomId);
                }
                else if (result == DialogResult.No)
                {
                    RejectBooking(bookingId);
                }
            }
            else
            {
                // No pending request - show option to change status
                msg.AppendLine("\nChange room status?");

                DialogResult result = MessageBox.Show(msg.ToString(), "Room Details",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    ShowChangeStatusOptions(roomId, roomNumber, status);
                }
            }
        }

        private void CompleteBookingByRoom(int roomId)
        {
            string sql = @"
        UPDATE bookings
        SET status = 'Completed',
            check_out_date = CURDATE()
        WHERE room_id = @roomId
        AND status = 'Approved'";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ShowChangeStatusOptions(int roomId, string roomNumber, string currentStatus)
        {
            string newStatus = "";

            if (currentStatus == "Maintenance")
            {
                DialogResult result = MessageBox.Show(
                    $"Set {roomNumber} back to Available?",
                    "Change Status",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    newStatus = "Available";
                }
            }
            else if (currentStatus == "Available")
            {
                DialogResult result = MessageBox.Show(
                    $"Set {roomNumber} to Maintenance?",
                    "Change Status",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    newStatus = "Maintenance";
                }
            }
            else if (currentStatus == "Occupied")
            {
                DialogResult result = MessageBox.Show(
                $"This room ({roomNumber}) is occupied. Are tenants leaving?",
                "Checkout Confirmation",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    CompleteBookingByRoom(roomId);

                    ChangeRoomStatus(roomId, "Dirty");
                    UpdateRoomButtonColor(roomNumber, "Dirty");

                    MessageBox.Show("Tenants checked out. Room marked for Housekeeping..");
                }
            }



            if (!string.IsNullOrEmpty(newStatus))
            {
                ChangeRoomStatus(roomId, newStatus);
                UpdateRoomButtonColor(roomNumber, newStatus);
            }
        }

        private DataRow GetRoomDetails(string roomNumber)
        {
            string sql = "SELECT room_id, room_number, capacity, rate, status FROM rooms WHERE room_number = @roomNumber";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomNumber", roomNumber);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }

        private DataRow GetCurrentTenantForRoom(int roomId)
        {
            string sql = @"SELECT t.full_name, t.contact_number, b.check_in_date, b.check_out_date
                          FROM bookings b
                          INNER JOIN tenants t ON b.tenant_id = t.tenant_id
                          WHERE b.room_id = @roomId 
                          AND b.status = 'Approved'
                          AND CURDATE() BETWEEN b.check_in_date AND b.check_out_date
                          LIMIT 1";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomId", roomId);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }

        private DataRow GetPendingBookingForRoom(int roomId)
        {
            string sql = @"SELECT b.booking_id, b.check_in_date, b.check_out_date, 
                                 t.full_name, t.contact_number
                          FROM bookings b
                          INNER JOIN tenants t ON b.tenant_id = t.tenant_id
                          WHERE b.room_id = @roomId 
                          AND b.status = 'Pending'
                          ORDER BY b.booking_id ASC
                          LIMIT 1";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomId", roomId);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }

        private void ApproveBooking(int bookingId, int roomId)
        {
            string sql = "UPDATE bookings SET status = 'Approved' WHERE booking_id = @bookingId";
            string sqlRoom = "UPDATE rooms SET status = 'Occupied' WHERE room_id = @roomId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sqlRoom, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Booking approved successfully!");
                LoadRoomStatuses(); // Refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving booking: " + ex.Message);
            }
        }

        private void RejectBooking(int bookingId)
        {
            string sql = "UPDATE bookings SET status = 'Rejected' WHERE booking_id = @bookingId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Booking rejected.");
                LoadRoomStatuses(); // Refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rejecting booking: " + ex.Message);
            }
        }

        private void ChangeRoomStatus(int roomId, string newStatus)
        {
            string sql = "UPDATE rooms SET status = @status WHERE room_id = @roomId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Room status changed to {newStatus}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing status: " + ex.Message);
            }
        }

        // ============ TENANT METHODS ============///////////////////////////////////////////////////////

        private void ShowTenantRoomDetails(string roomNumber)
        {
            DataRow roomData = GetRoomDetails(roomNumber);
            if (roomData == null) return;

            int roomId = Convert.ToInt32(roomData["room_id"]);
            string status = roomData["status"].ToString();
            int capacity = Convert.ToInt32(roomData["capacity"]);
            decimal rate = Convert.ToDecimal(roomData["rate"]);

            // --- PART 1: BOOKING LOGIC ---
            if (status == "Available")
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine($"Room: {roomNumber}");
                msg.AppendLine($"Capacity: {capacity} person(s)");
                msg.AppendLine($"Rate: ₱{rate:N2} per day");
                msg.AppendLine("-------------------");
                msg.AppendLine("Would you like to request this room?");

                DialogResult result = MessageBox.Show(msg.ToString(), "Available Room",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RequestRoom(roomId, roomNumber);
                }
            }
            else if (status == "Occupied")
            {
                MessageBox.Show("This room is currently occupied.", "Room Occupied");
            }
            else if (status == "Maintenance")
            {
                MessageBox.Show("This room is under maintenance.", "Room Unavailable");
            }

            // --- PART 2: FEEDBACK LOGIC (Independent of Status) ---
            // This allows a user to review a room they stayed in, even if it's now Occupied or Dirty
            if (HasUserStayedInRoom(roomId))
            {
                DialogResult result2 = MessageBox.Show("You have stayed in this room. Would you like to leave a review?",
                    "Room Feedback", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result2 == DialogResult.Yes)
                {
                    ReviewSubmissionForm revForm = new ReviewSubmissionForm(roomId, _userId, roomNumber);
                    revForm.ShowDialog();
                }
            }
        }

        private void RequestRoom(int roomId, string roomNumber)
        {
            // Check if tenant profile exists
            int? tenantId = GetTenantIdByUserId(_userId);

            if (tenantId == null)
            {
                MessageBox.Show("Please complete your tenant profile first.", "Profile Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use custom date input form
            using (DateInputForm dateForm = new DateInputForm())
            {
                if (dateForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime checkInDate = dateForm.CheckInDate;
                    DateTime checkOutDate = dateForm.CheckOutDate;

                    // Insert booking request
                    string sql = @"INSERT INTO bookings (tenant_id, room_id, check_in_date, check_out_date, status) 
                          VALUES (@tenantId, @roomId, @checkInDate, @checkOutDate, 'Pending')";

                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(conString))
                        {
                            conn.Open();
                            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@tenantId", tenantId);
                                cmd.Parameters.AddWithValue("@roomId", roomId);
                                cmd.Parameters.AddWithValue("@checkInDate", checkInDate.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@checkOutDate", checkOutDate.ToString("yyyy-MM-dd"));
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show($"Your request for {roomNumber} has been submitted!\nWaiting for admin approval.",
                            "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error submitting request: " + ex.Message);
                    }
                }
            }
        }
        private int? GetTenantIdByUserId(int userId)
        {
            string sql = "SELECT tenant_id FROM tenants WHERE user_id = @userId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                            return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return null;
        }


        private void Rooms_Load(object sender, EventArgs e)
        {
            LoadRoomStatuses();
        }

        private void s101Btn_Click(object sender, EventArgs e)
        {

        }
        private bool HasUserStayedInRoom(int roomId)
        {
            // We check for 'Approved' (currently staying) or 'Completed' (stayed before)
            string sql = @"SELECT COUNT(*) FROM bookings b
                   JOIN tenants t ON b.tenant_id = t.tenant_id
                   WHERE b.room_id = @roomId 
                   AND t.user_id = @userId 
                   AND (b.status = 'Approved' OR b.status = 'Completed')";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                        cmd.Parameters.AddWithValue("@userId", _userId);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Returns true if they have a valid history
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating history: " + ex.Message);
                return false;
            }
        }
        private void btnFeedbackManagement_Click(object sender, EventArgs e)
        {
            if (_role == "admin")
            {
                FeedbackManagerForm frm = new FeedbackManagerForm();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Admins only.");
            }
        }
    }
}