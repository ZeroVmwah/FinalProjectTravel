namespace FinalProjectTravel
{
    partial class LogIn
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
            loginpassword = new TextBox();
            Username = new Label();
            name = new TextBox();
            label1 = new Label();
            Si = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginpassword
            // 
            loginpassword.Location = new Point(201, 245);
            loginpassword.Margin = new Padding(3, 2, 3, 2);
            loginpassword.Name = "loginpassword";
            loginpassword.PasswordChar = '*';
            loginpassword.Size = new Size(173, 23);
            loginpassword.TabIndex = 13;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = SystemColors.ButtonHighlight;
            Username.Font = new Font("HP Simplified Hans", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Username.ForeColor = Color.Indigo;
            Username.Location = new Point(201, 105);
            Username.Name = "Username";
            Username.Size = new Size(77, 18);
            Username.TabIndex = 10;
            Username.Text = "Username";
            // 
            // name
            // 
            name.Location = new Point(201, 139);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(173, 23);
            name.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("HP Simplified Hans", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(201, 38);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 8;
            label1.Text = "Login Form";
            // 
            // Si
            // 
            Si.BackColor = Color.Indigo;
            Si.Font = new Font("HP Simplified Hans Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            Si.ForeColor = SystemColors.ControlLightLight;
            Si.Location = new Point(241, 304);
            Si.Margin = new Padding(3, 2, 3, 2);
            Si.Name = "Si";
            Si.Size = new Size(78, 38);
            Si.TabIndex = 15;
            Si.Text = "LOG IN";
            Si.UseVisualStyleBackColor = false;
            Si.Click += Si_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("HP Simplified Hans", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(201, 215);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.image_7__2_;
            ClientSize = new Size(598, 427);
            Controls.Add(label2);
            Controls.Add(Si);
            Controls.Add(loginpassword);
            Controls.Add(Username);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox loginpassword;
        private Label Username;
        private TextBox name;
        private Label label1;
        private Button Si;
        private Label label2;
    }
}