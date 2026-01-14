
namespace HotelManagement_Information_Management_2
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addUserBtn = new FontAwesome.Sharp.IconButton();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.numRoomsPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numRooms = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numCheckInPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numCheckIn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numAvail = new System.Windows.Forms.Label();
            this.numAvailPanel = new System.Windows.Forms.Label();
            this.numPendingPanel = new System.Windows.Forms.Panel();
            this.numPending = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numRoomsPanel.SuspendLayout();
            this.numCheckInPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.numPendingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addUserBtn.IconColor = System.Drawing.Color.White;
            this.addUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUserBtn.Location = new System.Drawing.Point(807, 525);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.addUserBtn.Size = new System.Drawing.Size(251, 75);
            this.addUserBtn.TabIndex = 9;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // numRoomsPanel
            // 
            this.numRoomsPanel.BackColor = System.Drawing.Color.White;
            this.numRoomsPanel.Controls.Add(this.label6);
            this.numRoomsPanel.Controls.Add(this.numRooms);
            this.numRoomsPanel.Controls.Add(this.label5);
            this.numRoomsPanel.Location = new System.Drawing.Point(77, 119);
            this.numRoomsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRoomsPanel.Name = "numRoomsPanel";
            this.numRoomsPanel.Size = new System.Drawing.Size(219, 215);
            this.numRoomsPanel.TabIndex = 11;
            this.numRoomsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.numRoomsPanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(78, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "of Rooms";
            // 
            // numRooms
            // 
            this.numRooms.AutoSize = true;
            this.numRooms.Font = new System.Drawing.Font("Arial Narrow", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRooms.ForeColor = System.Drawing.Color.Crimson;
            this.numRooms.Location = new System.Drawing.Point(70, 59);
            this.numRooms.Name = "numRooms";
            this.numRooms.Size = new System.Drawing.Size(78, 64);
            this.numRooms.TabIndex = 2;
            this.numRooms.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(71, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total number ";
            // 
            // numCheckInPanel
            // 
            this.numCheckInPanel.BackColor = System.Drawing.Color.White;
            this.numCheckInPanel.Controls.Add(this.label8);
            this.numCheckInPanel.Controls.Add(this.numCheckIn);
            this.numCheckInPanel.Controls.Add(this.label7);
            this.numCheckInPanel.Location = new System.Drawing.Point(807, 119);
            this.numCheckInPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCheckInPanel.Name = "numCheckInPanel";
            this.numCheckInPanel.Size = new System.Drawing.Size(219, 215);
            this.numCheckInPanel.TabIndex = 12;
            this.numCheckInPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.numCheckInPanel_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(78, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = " of Check-in";
            // 
            // numCheckIn
            // 
            this.numCheckIn.AutoSize = true;
            this.numCheckIn.Font = new System.Drawing.Font("Arial Narrow", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckIn.ForeColor = System.Drawing.Color.Red;
            this.numCheckIn.Location = new System.Drawing.Point(87, 59);
            this.numCheckIn.Name = "numCheckIn";
            this.numCheckIn.Size = new System.Drawing.Size(53, 64);
            this.numCheckIn.TabIndex = 2;
            this.numCheckIn.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(78, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total number ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.numAvail);
            this.panel4.Controls.Add(this.numAvailPanel);
            this.panel4.Location = new System.Drawing.Point(440, 119);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 215);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(79, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = " Available Rooms";
            // 
            // numAvail
            // 
            this.numAvail.AutoSize = true;
            this.numAvail.Font = new System.Drawing.Font("Arial Narrow", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAvail.ForeColor = System.Drawing.Color.Red;
            this.numAvail.Location = new System.Drawing.Point(90, 59);
            this.numAvail.Name = "numAvail";
            this.numAvail.Size = new System.Drawing.Size(53, 64);
            this.numAvail.TabIndex = 2;
            this.numAvail.Text = "3";
            // 
            // numAvailPanel
            // 
            this.numAvailPanel.AutoSize = true;
            this.numAvailPanel.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAvailPanel.ForeColor = System.Drawing.Color.DarkCyan;
            this.numAvailPanel.Location = new System.Drawing.Point(84, 159);
            this.numAvailPanel.Name = "numAvailPanel";
            this.numAvailPanel.Size = new System.Drawing.Size(83, 15);
            this.numAvailPanel.TabIndex = 1;
            this.numAvailPanel.Text = "Total number of ";
            // 
            // numPendingPanel
            // 
            this.numPendingPanel.BackColor = System.Drawing.Color.White;
            this.numPendingPanel.Controls.Add(this.numPending);
            this.numPendingPanel.Controls.Add(this.label4);
            this.numPendingPanel.Location = new System.Drawing.Point(77, 385);
            this.numPendingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPendingPanel.Name = "numPendingPanel";
            this.numPendingPanel.Size = new System.Drawing.Size(219, 215);
            this.numPendingPanel.TabIndex = 12;
            this.numPendingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.numPendingPanel_Paint);
            // 
            // numPending
            // 
            this.numPending.AutoSize = true;
            this.numPending.Font = new System.Drawing.Font("Arial Narrow", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPending.ForeColor = System.Drawing.Color.Crimson;
            this.numPending.Location = new System.Drawing.Point(89, 52);
            this.numPending.Name = "numPending";
            this.numPending.Size = new System.Drawing.Size(53, 64);
            this.numPending.TabIndex = 2;
            this.numPending.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total number of Pending";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 721);
            this.Controls.Add(this.numPendingPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.numCheckInPanel);
            this.Controls.Add(this.numRoomsPanel);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.numRoomsPanel.ResumeLayout(false);
            this.numRoomsPanel.PerformLayout();
            this.numCheckInPanel.ResumeLayout(false);
            this.numCheckInPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.numPendingPanel.ResumeLayout(false);
            this.numPendingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton addUserBtn;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Panel numRoomsPanel;
        private System.Windows.Forms.Label numRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel numCheckInPanel;
        private System.Windows.Forms.Label numCheckIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label numAvail;
        private System.Windows.Forms.Label numAvailPanel;
        private System.Windows.Forms.Panel numPendingPanel;
        private System.Windows.Forms.Label numPending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}