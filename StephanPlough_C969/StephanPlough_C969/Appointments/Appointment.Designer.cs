namespace StephanPlough_C969
{
    partial class Appointment
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            AllAppointments = new RadioButton();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(162, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(743, 456);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 1;
            label1.Text = "Appointments";
            // 
            // button1
            // 
            button1.Location = new Point(12, 65);
            button1.Name = "button1";
            button1.Size = new Size(126, 46);
            button1.TabIndex = 2;
            button1.Text = "Add Appointment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 145);
            button2.Name = "button2";
            button2.Size = new Size(126, 46);
            button2.TabIndex = 3;
            button2.Text = "Edit Appointment";
            button2.UseVisualStyleBackColor = true;
            button2.Click += editAppointment_Click;
            // 
            // button3
            // 
            button3.Location = new Point(510, 531);
            button3.Name = "button3";
            button3.Size = new Size(126, 46);
            button3.TabIndex = 4;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(357, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 7;
            radioButton1.Text = "Monthly";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += MonthlyButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(258, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 8;
            radioButton2.Text = "Weekly";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += WeeklyButton_CheckedChanged;
            // 
            // AllAppointments
            // 
            AllAppointments.AutoSize = true;
            AllAppointments.Checked = true;
            AllAppointments.Location = new Point(162, 26);
            AllAppointments.Name = "AllAppointments";
            AllAppointments.Size = new Size(39, 19);
            AllAppointments.TabIndex = 9;
            AllAppointments.TabStop = true;
            AllAppointments.Text = "All";
            AllAppointments.UseVisualStyleBackColor = true;
            AllAppointments.CheckedChanged += AllAppointments_CheckedChanged;
            // 
            // button4
            // 
            button4.Location = new Point(12, 227);
            button4.Name = "button4";
            button4.Size = new Size(126, 46);
            button4.TabIndex = 10;
            button4.Text = "Delete Appointment";
            button4.UseVisualStyleBackColor = true;
            button4.Click += delete_Click;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(804, 581);
            Controls.Add(button4);
            Controls.Add(AllAppointments);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Appointment";
            Text = "Appointment";
            Load += Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton AllAppointments;
        private Button button4;
    }
}