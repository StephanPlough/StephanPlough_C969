namespace StephanPlough_C969
{
    partial class AddAppointment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            DatePickerStart = new DateTimePicker();
            DateTimePickerEnd = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Appointment ID:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Customer ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Appointment Type";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 271);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "End";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // DatePickerStart
            // 
            DatePickerStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            DatePickerStart.Format = DateTimePickerFormat.Custom;
            DatePickerStart.Location = new Point(16, 215);
            DatePickerStart.Name = "DatePickerStart";
            DatePickerStart.Size = new Size(200, 23);
            DatePickerStart.TabIndex = 7;
            DatePickerStart.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // DateTimePickerEnd
            // 
            DateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            DateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            DateTimePickerEnd.Location = new Point(16, 289);
            DateTimePickerEnd.Name = "DateTimePickerEnd";
            DateTimePickerEnd.Size = new Size(200, 23);
            DateTimePickerEnd.TabIndex = 8;
            DateTimePickerEnd.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(257, 253);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Add Appointment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addAppointment_Click;
            // 
            // button2
            // 
            button2.Location = new Point(257, 291);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 106);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(107, 14);
            label6.Name = "label6";
            label6.Size = new Size(45, 16);
            label6.TabIndex = 12;
            label6.Text = "label6";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(125, 48);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 13;
            label7.Text = "Hours: 7A - 10P";
            label7.Click += label7_Click;
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 349);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DateTimePickerEnd);
            Controls.Add(DatePickerStart);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAppointment";
            Text = "AddAppointment";
            Load += AddAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker DatePickerStart;
        private DateTimePicker DateTimePickerEnd;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
    }
}