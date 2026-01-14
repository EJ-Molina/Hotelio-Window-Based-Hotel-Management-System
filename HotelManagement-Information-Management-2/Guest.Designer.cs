
namespace HotelManagement_Information_Management_2
{
    partial class Guest
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmegencyContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FullNameCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emergencyTxt = new System.Windows.Forms.TextBox();
            this.dad = new System.Windows.Forms.Label();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.fdaw = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.idTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(361, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Checked-in";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.ContactNumber,
            this.EmegencyContact,
            this.Room,
            this.CheckIn,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(365, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 188);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            this.ContactNumber.Width = 125;
            // 
            // EmegencyContact
            // 
            this.EmegencyContact.HeaderText = "Emergency Contact";
            this.EmegencyContact.MinimumWidth = 6;
            this.EmegencyContact.Name = "EmegencyContact";
            this.EmegencyContact.ReadOnly = true;
            this.EmegencyContact.Width = 125;
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 125;
            // 
            // CheckIn
            // 
            this.CheckIn.HeaderText = "Check In";
            this.CheckIn.MinimumWidth = 6;
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            this.CheckIn.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameCo,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(365, 423);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(669, 185);
            this.dataGridView2.TabIndex = 13;
            // 
            // FullNameCo
            // 
            this.FullNameCo.HeaderText = "Full Name";
            this.FullNameCo.MinimumWidth = 6;
            this.FullNameCo.Name = "FullNameCo";
            this.FullNameCo.ReadOnly = true;
            this.FullNameCo.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Contact Number";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Emergency Contact";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Room";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Check Out";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(361, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Checked-out";
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Enabled = false;
            this.fullnameTxt.Location = new System.Drawing.Point(148, 231);
            this.fullnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(209, 22);
            this.fullnameTxt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Full Name";
            // 
            // emergencyTxt
            // 
            this.emergencyTxt.Enabled = false;
            this.emergencyTxt.Location = new System.Drawing.Point(148, 338);
            this.emergencyTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emergencyTxt.Name = "emergencyTxt";
            this.emergencyTxt.Size = new System.Drawing.Size(209, 22);
            this.emergencyTxt.TabIndex = 22;
            // 
            // dad
            // 
            this.dad.AutoSize = true;
            this.dad.Location = new System.Drawing.Point(7, 338);
            this.dad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dad.Name = "dad";
            this.dad.Size = new System.Drawing.Size(131, 17);
            this.dad.TabIndex = 21;
            this.dad.Text = "Emergency Contact";
            // 
            // contactTxt
            // 
            this.contactTxt.Enabled = false;
            this.contactTxt.Location = new System.Drawing.Point(148, 288);
            this.contactTxt.Margin = new System.Windows.Forms.Padding(4);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(209, 22);
            this.contactTxt.TabIndex = 20;
            // 
            // fdaw
            // 
            this.fdaw.AutoSize = true;
            this.fdaw.Location = new System.Drawing.Point(7, 288);
            this.fdaw.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fdaw.Name = "fdaw";
            this.fdaw.Size = new System.Drawing.Size(110, 17);
            this.fdaw.TabIndex = 19;
            this.fdaw.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "hiddenID";
            this.label5.Visible = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editBtn.IconColor = System.Drawing.Color.White;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(776, 27);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(247, 75);
            this.editBtn.TabIndex = 25;
            this.editBtn.Text = "Edit User";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.saveBtn.Enabled = false;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.saveBtn.IconColor = System.Drawing.Color.White;
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(48, 465);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.saveBtn.Size = new System.Drawing.Size(227, 57);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(148, 175);
            this.idTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(209, 22);
            this.idTxt.TabIndex = 27;
            this.idTxt.Visible = false;
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 706);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.fullnameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emergencyTxt);
            this.Controls.Add(this.dad);
            this.Controls.Add(this.contactTxt);
            this.Controls.Add(this.fdaw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Guest";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmegencyContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.TextBox fullnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emergencyTxt;
        private System.Windows.Forms.Label dad;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.Label fdaw;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton editBtn;
        private FontAwesome.Sharp.IconButton saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}