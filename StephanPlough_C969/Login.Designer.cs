namespace StephanPlough_C969
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logIn_RememberMeCheckBox = new CheckBox();
            logIn_PasswordTextBox = new TextBox();
            logIn_UserNameTextBox = new TextBox();
            logIn_LogInButton = new Button();
            logIn_Label = new Label();
            English = new RadioButton();
            radioButton2 = new RadioButton();
            button2 = new Button();
            SuspendLayout();
            // 
            // logIn_RememberMeCheckBox
            // 
            logIn_RememberMeCheckBox.AutoSize = true;
            logIn_RememberMeCheckBox.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logIn_RememberMeCheckBox.Location = new Point(12, 105);
            logIn_RememberMeCheckBox.Name = "logIn_RememberMeCheckBox";
            logIn_RememberMeCheckBox.Size = new Size(15, 14);
            logIn_RememberMeCheckBox.TabIndex = 0;
            logIn_RememberMeCheckBox.UseVisualStyleBackColor = true;
            logIn_RememberMeCheckBox.CheckedChanged += logIn_RememberMeCheckBox_CheckedChanged;
            // 
            // logIn_PasswordTextBox
            // 
            logIn_PasswordTextBox.Location = new Point(12, 76);
            logIn_PasswordTextBox.Name = "logIn_PasswordTextBox";
            logIn_PasswordTextBox.Size = new Size(285, 23);
            logIn_PasswordTextBox.TabIndex = 1;
            logIn_PasswordTextBox.Click += logIn_PasswordTextBox_Click;
            logIn_PasswordTextBox.TextChanged += logIn_PasswordTextBox_TextChanged;
            // 
            // logIn_UserNameTextBox
            // 
            logIn_UserNameTextBox.Location = new Point(12, 47);
            logIn_UserNameTextBox.Name = "logIn_UserNameTextBox";
            logIn_UserNameTextBox.Size = new Size(285, 23);
            logIn_UserNameTextBox.TabIndex = 2;
            logIn_UserNameTextBox.Click += logIn_UserNameTextBox_Click;
            logIn_UserNameTextBox.TextChanged += logIn_UsernameTextBox_TextChanged;
            // 
            // logIn_LogInButton
            // 
            logIn_LogInButton.Location = new Point(222, 105);
            logIn_LogInButton.Name = "logIn_LogInButton";
            logIn_LogInButton.Size = new Size(75, 23);
            logIn_LogInButton.TabIndex = 3;
            logIn_LogInButton.Text = "Log In";
            logIn_LogInButton.UseVisualStyleBackColor = true;
            logIn_LogInButton.Click += logIn_LogInButton_Click;
            // 
            // logIn_Label
            // 
            logIn_Label.AutoSize = true;
            logIn_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logIn_Label.Location = new Point(96, 9);
            logIn_Label.Name = "logIn_Label";
            logIn_Label.Size = new Size(147, 15);
            logIn_Label.TabIndex = 4;
            logIn_Label.Text = "Plough's Conference Tool";
            logIn_Label.Click += logIn_Label_Click;
            // 
            // English
            // 
            English.AutoSize = true;
            English.Location = new Point(25, 181);
            English.Name = "English";
            English.Size = new Size(63, 19);
            English.TabIndex = 6;
            English.TabStop = true;
            English.Text = "English";
            English.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(25, 217);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "German";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(119, 105);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += resetButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(334, 146);
            Controls.Add(button2);
            Controls.Add(radioButton2);
            Controls.Add(English);
            Controls.Add(logIn_Label);
            Controls.Add(logIn_LogInButton);
            Controls.Add(logIn_UserNameTextBox);
            Controls.Add(logIn_PasswordTextBox);
            Controls.Add(logIn_RememberMeCheckBox);
            Name = "Login";
            Text = "Log In";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox logIn_RememberMeCheckBox;
        private TextBox logIn_PasswordTextBox;
        private TextBox logIn_UserNameTextBox;
        private Button logIn_LogInButton;
        private Label logIn_Label;
        private RadioButton English;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
    }
}