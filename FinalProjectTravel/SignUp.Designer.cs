namespace FinalProjectTravel
{
    partial class SignUp
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
            name = new TextBox();
            Username = new Label();
            email = new Label();
            mail = new TextBox();
            password = new Label();
            mypassword = new TextBox();
            length = new Label();
            capital = new Label();
            number = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            phone = new TextBox();
            Si = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(147, 122);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(86, 21);
            name.TabIndex = 1;
            name.Validating += name_Validating;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = SystemColors.ButtonHighlight;
            Username.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Username.ForeColor = Color.Indigo;
            Username.Location = new Point(147, 102);
            Username.Name = "Username";
            Username.Size = new Size(59, 13);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = SystemColors.ButtonHighlight;
            email.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = Color.Indigo;
            email.Location = new Point(147, 159);
            email.Name = "email";
            email.Size = new Size(40, 13);
            email.TabIndex = 5;
            email.Text = "E-mail";
            // 
            // mail
            // 
            mail.Location = new Point(147, 184);
            mail.Margin = new Padding(3, 2, 3, 2);
            mail.Name = "mail";
            mail.Size = new Size(86, 21);
            mail.TabIndex = 4;
            mail.Validating += mail_Validating;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = SystemColors.ButtonHighlight;
            password.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Indigo;
            password.Location = new Point(147, 217);
            password.Name = "password";
            password.Size = new Size(59, 13);
            password.TabIndex = 7;
            password.Text = "Password";
            // 
            // mypassword
            // 
            mypassword.Location = new Point(147, 236);
            mypassword.Margin = new Padding(3, 2, 3, 2);
            mypassword.Name = "mypassword";
            mypassword.PasswordChar = '*';
            mypassword.Size = new Size(86, 21);
            mypassword.TabIndex = 6;
            mypassword.TextChanged += mypassword_TextChanged;
            mypassword.Validating += mypassword_Validating;
            // 
            // length
            // 
            length.AutoSize = true;
            length.BackColor = SystemColors.ButtonHighlight;
            length.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            length.ForeColor = Color.Indigo;
            length.Location = new Point(334, 197);
            length.Name = "length";
            length.Size = new Size(211, 13);
            length.TabIndex = 10;
            length.Text = "should include more than 8 characters.";
            length.Visible = false;
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.BackColor = SystemColors.ButtonHighlight;
            capital.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            capital.ForeColor = Color.Indigo;
            capital.Location = new Point(334, 219);
            capital.Name = "capital";
            capital.Size = new Size(216, 13);
            capital.TabIndex = 11;
            capital.Text = "should include at least one capital letter";
            capital.Visible = false;
            // 
            // number
            // 
            number.AutoSize = true;
            number.BackColor = SystemColors.ButtonHighlight;
            number.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            number.ForeColor = Color.Indigo;
            number.Location = new Point(334, 242);
            number.Name = "number";
            number.Size = new Size(196, 13);
            number.TabIndex = 12;
            number.Text = "should include at least one number.";
            number.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(304, 134);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.MaxDate = new DateTime(2024, 1, 15, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 21);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Value = new DateTime(2006, 1, 15, 0, 0, 0, 0);
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(304, 95);
            label3.Name = "label3";
            label3.Size = new Size(73, 13);
            label3.TabIndex = 14;
            label3.Text = "Date of Birth";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "female", "male", "other", "prefer not to say" });
            listBox1.Location = new Point(147, 291);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(103, 17);
            listBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(147, 276);
            label4.Name = "label4";
            label4.Size = new Size(44, 13);
            label4.TabIndex = 16;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(147, 321);
            label5.Name = "label5";
            label5.Size = new Size(85, 13);
            label5.TabIndex = 17;
            label5.Text = "Phone number";
            // 
            // phone
            // 
            phone.Location = new Point(147, 348);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Name = "phone";
            phone.Size = new Size(86, 21);
            phone.TabIndex = 18;
            phone.Validating += phone_Validating;
            // 
            // Si
            // 
            Si.BackColor = Color.Indigo;
            Si.Font = new Font("HP Simplified Hans Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            Si.ForeColor = SystemColors.ControlLightLight;
            Si.Location = new Point(344, 348);
            Si.Margin = new Padding(3, 2, 3, 2);
            Si.Name = "Si";
            Si.Size = new Size(97, 38);
            Si.TabIndex = 19;
            Si.Text = "CREATE";
            Si.UseVisualStyleBackColor = false;
            Si.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("HP Simplified Hans", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(147, 34);
            label1.Name = "label1";
            label1.Size = new Size(217, 29);
            label1.TabIndex = 20;
            label1.Text = "Registration Form";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.image_7__2_;
            ClientSize = new Size(597, 432);
            Controls.Add(label1);
            Controls.Add(Si);
            Controls.Add(phone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(number);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(password);
            Controls.Add(mypassword);
            Controls.Add(email);
            Controls.Add(mail);
            Controls.Add(Username);
            Controls.Add(name);
            Font = new Font("HP Simplified Hans", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Indigo;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox name;
        private Label Username;
        private Label email;
        private TextBox mail;
        private Label password;
        private TextBox mypassword;
        private Label length;
        private Label capital;
        private Label number;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private Label label5;
        private TextBox phone;
        private Button Si;
        private Label label1;
    }
}