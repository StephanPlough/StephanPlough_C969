namespace StephanPlough_C969
{
    partial class AppointmentReport
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
            Label label1;
            dataGridView1 = new DataGridView();
            typeComboBox = new ComboBox();
            textBoxMonth = new TextBox();
            searchButton = new Button();
            goBackButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 17);
            label1.TabIndex = 1;
            label1.Text = "Appointment Report";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(583, 201);
            dataGridView1.TabIndex = 0;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(352, 97);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(121, 23);
            typeComboBox.TabIndex = 2;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(479, 97);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(100, 23);
            textBoxMonth.TabIndex = 3;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(585, 97);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(479, 333);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(75, 23);
            goBackButton.TabIndex = 5;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(585, 333);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // AppointmentReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(730, 395);
            Controls.Add(exitButton);
            Controls.Add(goBackButton);
            Controls.Add(searchButton);
            Controls.Add(textBoxMonth);
            Controls.Add(typeComboBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AppointmentReport";
            Text = "AppointmentReport";
            Load += AppointmentReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox typeComboBox;
        private TextBox textBoxMonth;
        private Button searchButton;
        private Button goBackButton;
        private Button exitButton;
    }
}