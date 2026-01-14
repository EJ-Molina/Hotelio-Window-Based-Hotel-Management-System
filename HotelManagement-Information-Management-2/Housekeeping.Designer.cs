
namespace HotelManagement_Information_Management_2
{
    partial class Housekeeping
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
            this.dgvHousekeeping = new System.Windows.Forms.DataGridView();
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.staffNameTxt = new System.Windows.Forms.TextBox();
            this.scheduledDatePicker = new System.Windows.Forms.DateTimePicker();
            this.assignBtn = new System.Windows.Forms.Button();
            this.updateStatusBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousekeeping)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHousekeeping
            // 
            this.dgvHousekeeping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHousekeeping.Location = new System.Drawing.Point(-3, 141);
            this.dgvHousekeeping.Name = "dgvHousekeeping";
            this.dgvHousekeeping.ReadOnly = true;
            this.dgvHousekeeping.RowHeadersWidth = 51;
            this.dgvHousekeeping.RowTemplate.Height = 24;
            this.dgvHousekeeping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHousekeeping.Size = new System.Drawing.Size(1175, 510);
            this.dgvHousekeeping.TabIndex = 0;
            // 
            // roomCombo
            // 
            this.roomCombo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.roomCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Location = new System.Drawing.Point(417, 22);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(186, 24);
            this.roomCombo.TabIndex = 1;
            this.roomCombo.SelectedIndexChanged += new System.EventHandler(this.roomCombo_SelectedIndexChanged);
            // 
            // staffNameTxt
            // 
            this.staffNameTxt.Location = new System.Drawing.Point(118, 17);
            this.staffNameTxt.Name = "staffNameTxt";
            this.staffNameTxt.Size = new System.Drawing.Size(186, 22);
            this.staffNameTxt.TabIndex = 2;
            // 
            // scheduledDatePicker
            // 
            this.scheduledDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.scheduledDatePicker.Location = new System.Drawing.Point(780, 20);
            this.scheduledDatePicker.Name = "scheduledDatePicker";
            this.scheduledDatePicker.Size = new System.Drawing.Size(171, 22);
            this.scheduledDatePicker.TabIndex = 3;
            // 
            // assignBtn
            // 
            this.assignBtn.ForeColor = System.Drawing.Color.Teal;
            this.assignBtn.Location = new System.Drawing.Point(812, 81);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(130, 37);
            this.assignBtn.TabIndex = 4;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // updateStatusBtn
            // 
            this.updateStatusBtn.ForeColor = System.Drawing.Color.Teal;
            this.updateStatusBtn.Location = new System.Drawing.Point(985, 81);
            this.updateStatusBtn.Name = "updateStatusBtn";
            this.updateStatusBtn.Size = new System.Drawing.Size(131, 37);
            this.updateStatusBtn.TabIndex = 5;
            this.updateStatusBtn.Text = "Update";
            this.updateStatusBtn.UseVisualStyleBackColor = true;
            this.updateStatusBtn.Click += new System.EventHandler(this.completeTaskBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assign Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Scheduled Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.staffNameTxt);
            this.panel1.Controls.Add(this.updateStatusBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.assignBtn);
            this.panel1.Controls.Add(this.roomCombo);
            this.panel1.Controls.Add(this.scheduledDatePicker);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 135);
            this.panel1.TabIndex = 9;
            // 
            // Housekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHousekeeping);
            this.Name = "Housekeeping";
            this.Text = "Housekeeping";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHousekeeping)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHousekeeping;
        private System.Windows.Forms.ComboBox roomCombo;
        private System.Windows.Forms.TextBox staffNameTxt;
        private System.Windows.Forms.DateTimePicker scheduledDatePicker;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.Button updateStatusBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}