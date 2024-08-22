namespace StephanPlough_C969
{
    partial class UpdateCustomer
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBoxCountry = new TextBox();
            label6 = new Label();
            textBoxCity = new TextBox();
            label5 = new Label();
            textBoxPhoneNumber = new TextBox();
            textBoxAddress = new TextBox();
            textBoxCustomer = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(22, 367);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 27;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 338);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Clear Field";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(22, 338);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(12, 294);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(191, 23);
            textBoxCountry.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 276);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 23;
            label6.Text = "Country Name";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(12, 237);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(191, 23);
            textBoxCity.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 21;
            label5.Text = "City Name";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(12, 182);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(191, 23);
            textBoxPhoneNumber.TabIndex = 20;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 124);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(191, 23);
            textBoxAddress.TabIndex = 19;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(12, 67);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(191, 23);
            textBoxCustomer.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 17;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 16;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 14;
            label1.Text = "Edit A Customer";
            // 
            // UpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(215, 399);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxCountry);
            Controls.Add(label6);
            Controls.Add(textBoxCity);
            Controls.Add(label5);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateCustomer";
            Text = "EditCustomer";
            Load += UpdateCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox textBoxAddress;
        public TextBox textBoxPhoneNumber;
        public TextBox textBoxCity;
        public TextBox textBoxCountry;
        public TextBox textBoxCustomer;
    }
}