namespace StephanPlough_C969
{
    partial class AddCustomer
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
            textBox_Name = new TextBox();
            textBox_Address = new TextBox();
            textBox_PhoneNum = new TextBox();
            textBox_City = new TextBox();
            label5 = new Label();
            textBox_Country = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            textBox_Zip = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Add A Customer";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            label4.Click += label4_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 67);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(191, 23);
            textBox_Name.TabIndex = 4;
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(12, 124);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(191, 23);
            textBox_Address.TabIndex = 5;
            // 
            // textBox_PhoneNum
            // 
            textBox_PhoneNum.Location = new Point(12, 182);
            textBox_PhoneNum.Name = "textBox_PhoneNum";
            textBox_PhoneNum.Size = new Size(191, 23);
            textBox_PhoneNum.TabIndex = 6;
            // 
            // textBox_City
            // 
            textBox_City.Location = new Point(12, 237);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(191, 23);
            textBox_City.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "City Name";
            // 
            // textBox_Country
            // 
            textBox_Country.Location = new Point(12, 294);
            textBox_Country.Name = "textBox_Country";
            textBox_Country.Size = new Size(191, 23);
            textBox_Country.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 276);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 9;
            label6.Text = "Country Name";
            // 
            // button1
            // 
            button1.Location = new Point(22, 410);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += save_Click;
            // 
            // button2
            // 
            button2.Location = new Point(111, 439);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Clear Field";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(22, 439);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 329);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 14;
            label7.Text = "Zip Code";
            // 
            // textBox_Zip
            // 
            textBox_Zip.Location = new Point(12, 347);
            textBox_Zip.Name = "textBox_Zip";
            textBox_Zip.Size = new Size(191, 23);
            textBox_Zip.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "label8";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(215, 484);
            Controls.Add(label8);
            Controls.Add(textBox_Zip);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_Country);
            Controls.Add(label6);
            Controls.Add(textBox_City);
            Controls.Add(label5);
            Controls.Add(textBox_PhoneNum);
            Controls.Add(textBox_Address);
            Controls.Add(textBox_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "AddCustomer";
            Load += AddCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_Name;
        private TextBox textBox_Address;
        private TextBox textBox_PhoneNum;
        private TextBox textBox_City;
        private Label label5;
        private TextBox textBox_Country;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox textBox_Zip;
        private Label label8;
    }
}