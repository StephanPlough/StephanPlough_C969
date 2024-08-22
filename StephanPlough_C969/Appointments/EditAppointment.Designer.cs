namespace StephanPlough_C969
{
    partial class EditAppointment
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
            label7 = new Label();
            label6 = new Label();
            customerComboBox = new ComboBox();
            button2 = new Button();
            updateButton = new Button();
            DateTimePickerEnd = new DateTimePicker();
            DatePickerStart = new DateTimePicker();
            typeComboBox = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(130, 58);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 26;
            label7.Text = "Hours: 7A - 10P";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(112, 24);
            label6.Name = "label6";
            label6.Size = new Size(45, 16);
            label6.TabIndex = 25;
            label6.Text = "label6";
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(17, 116);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(121, 23);
            customerComboBox.TabIndex = 24;
            customerComboBox.SelectedIndexChanged += customerComboBox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(262, 301);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(262, 263);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 22;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerEnd
            // 
            DateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            DateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            DateTimePickerEnd.Location = new Point(21, 299);
            DateTimePickerEnd.Name = "DateTimePickerEnd";
            DateTimePickerEnd.Size = new Size(200, 23);
            DateTimePickerEnd.TabIndex = 21;
            DateTimePickerEnd.ValueChanged += DateTimePickerEnd_ValueChanged;
            // 
            // DatePickerStart
            // 
            DatePickerStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            DatePickerStart.Format = DateTimePickerFormat.Custom;
            DatePickerStart.Location = new Point(21, 225);
            DatePickerStart.Name = "DatePickerStart";
            DatePickerStart.Size = new Size(200, 23);
            DatePickerStart.TabIndex = 20;
            DatePickerStart.ValueChanged += DatePickerStart_ValueChanged;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(17, 172);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(121, 23);
            typeComboBox.TabIndex = 19;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 281);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 18;
            label5.Text = "End";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 207);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 17;
            label4.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 154);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 16;
            label3.Text = "Appointment Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 98);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 15;
            label2.Text = "Customer ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 14;
            label1.Text = "Appointment ID:  ";
            // 
            // EditAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 349);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(customerComboBox);
            Controls.Add(button2);
            Controls.Add(updateButton);
            Controls.Add(DateTimePickerEnd);
            Controls.Add(DatePickerStart);
            Controls.Add(typeComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditAppointment";
            Text = "EditAppointment";
            Load += EditAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button button2;
        private Button updateButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public ComboBox customerComboBox;
        public ComboBox typeComboBox;
        public DateTimePicker DatePickerStart;
        public DateTimePicker DateTimePickerEnd;
        public Label label6;
    }
}