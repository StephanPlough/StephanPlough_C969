namespace StephanPlough_C969
{
    partial class ConsultantReport
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
            dgvConsultantReport = new DataGridView();
            goBackButton = new Button();
            exitButton = new Button();
            searchButton = new Button();
            searchUserTextbox = new TextBox();
            consultantReportLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsultantReport).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultantReport
            // 
            dgvConsultantReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultantReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsultantReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultantReport.Location = new Point(33, 92);
            dgvConsultantReport.Name = "dgvConsultantReport";
            dgvConsultantReport.ReadOnly = true;
            dgvConsultantReport.RowTemplate.Height = 25;
            dgvConsultantReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultantReport.Size = new Size(733, 299);
            dgvConsultantReport.TabIndex = 0;
            dgvConsultantReport.CellContentClick += dataGridView1_CellContentClick;
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(551, 397);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(102, 30);
            goBackButton.TabIndex = 1;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBack_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(664, 397);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(102, 30);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(664, 56);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(102, 30);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search User";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchUserTextbox
            // 
            searchUserTextbox.Location = new Point(530, 61);
            searchUserTextbox.Name = "searchUserTextbox";
            searchUserTextbox.Size = new Size(123, 23);
            searchUserTextbox.TabIndex = 4;
            searchUserTextbox.TextChanged += searchUserTextbox_TextChanged;
            // 
            // consultantReportLabel
            // 
            consultantReportLabel.AutoSize = true;
            consultantReportLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            consultantReportLabel.Location = new Point(342, 9);
            consultantReportLabel.Name = "consultantReportLabel";
            consultantReportLabel.Size = new Size(120, 17);
            consultantReportLabel.TabIndex = 5;
            consultantReportLabel.Text = "Consultant Report";
            // 
            // ConsultantReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(800, 450);
            Controls.Add(consultantReportLabel);
            Controls.Add(searchUserTextbox);
            Controls.Add(searchButton);
            Controls.Add(exitButton);
            Controls.Add(goBackButton);
            Controls.Add(dgvConsultantReport);
            Name = "ConsultantReport";
            Text = "ConsultantReport";
            Load += ConsultantReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultantReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConsultantReport;
        private Button goBackButton;
        private Button exitButton;
        private Button searchButton;
        private TextBox searchUserTextbox;
        private Label consultantReportLabel;
    }
}