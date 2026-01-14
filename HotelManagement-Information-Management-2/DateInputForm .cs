using System;
using System.Windows.Forms;

namespace HotelManagement_Information_Management_2
{
    public partial class DateInputForm : Form
    {
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }

        private DateTimePicker checkInPicker;
        private DateTimePicker checkOutPicker;
        private Button okButton;
        private Button cancelButton;
        private Label label1;
        private Label label2;

        public DateInputForm()
        {
            InitializeComponent();
            // Call setup AFTER InitializeComponent
        }

        private void DateInputForm_Load(object sender, EventArgs e)
        {
            SetupControls();
        }

        private void SetupControls()
        {
            this.Text = "Select Dates";
            this.Size = new System.Drawing.Size(350, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            label1 = new Label();
            label1.Text = "Check-in Date:";
            label1.Location = new System.Drawing.Point(20, 20);
            label1.Size = new System.Drawing.Size(100, 20);

            checkInPicker = new DateTimePicker();
            checkInPicker.Location = new System.Drawing.Point(130, 20);
            checkInPicker.Size = new System.Drawing.Size(180, 20);
            checkInPicker.MinDate = DateTime.Now;
            checkInPicker.Value = DateTime.Now;

            label2 = new Label();
            label2.Text = "Check-out Date:";
            label2.Location = new System.Drawing.Point(20, 60);
            label2.Size = new System.Drawing.Size(100, 20);

            checkOutPicker = new DateTimePicker();
            checkOutPicker.Location = new System.Drawing.Point(130, 60);
            checkOutPicker.Size = new System.Drawing.Size(180, 20);
            checkOutPicker.MinDate = DateTime.Now.AddDays(1);
            checkOutPicker.Value = DateTime.Now.AddDays(1);

            okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new System.Drawing.Point(130, 110);
            okButton.Size = new System.Drawing.Size(80, 30);
            okButton.Click += OkButton_Click;

            cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Location = new System.Drawing.Point(230, 110);
            cancelButton.Size = new System.Drawing.Size(80, 30);
            cancelButton.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            this.Controls.Add(label1);
            this.Controls.Add(checkInPicker);
            this.Controls.Add(label2);
            this.Controls.Add(checkOutPicker);
            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (checkOutPicker.Value <= checkInPicker.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Invalid Dates",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CheckInDate = checkInPicker.Value;
            CheckOutDate = checkOutPicker.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}