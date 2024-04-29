namespace FinalProjectTravel
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            Destination = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            bud = new TextBox();
            button1 = new Button();
            act = new TextBox();
            city = new TextBox();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 53);
            label1.Name = "label1";
            label1.Size = new Size(250, 38);
            label1.TabIndex = 0;
            label1.Text = "PLAN YOUR TRIP!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 144);
            label2.Name = "label2";
            label2.Size = new Size(171, 18);
            label2.TabIndex = 1;
            label2.Text = "Select your destination:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Destination
            // 
            Destination.DropDownStyle = ComboBoxStyle.Simple;
            Destination.FormattingEnabled = true;
            Destination.Items.AddRange(new object[] { "Bulgaria", "Japan", "Singapore", "Spain", "France", "New Guinea", "Jamaica", "Taiwan", "Bali" });
            Destination.Location = new Point(100, 178);
            Destination.Name = "Destination";
            Destination.Size = new Size(131, 150);
            Destination.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(301, 250);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 4;
            label3.Text = "Choose some activities:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(519, 144);
            label4.Name = "label4";
            label4.Size = new Size(213, 20);
            label4.TabIndex = 6;
            label4.Text = "Select the days of your travel:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Location = new Point(519, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("HP Simplified Hans Light", 9.749999F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(519, 183);
            label6.Name = "label6";
            label6.Size = new Size(97, 14);
            label6.TabIndex = 9;
            label6.Text = "Beginning of trip";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("HP Simplified Hans Light", 9.749999F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(519, 252);
            label5.Name = "label5";
            label5.Size = new Size(63, 14);
            label5.TabIndex = 10;
            label5.Text = "End of trip";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(519, 286);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(134, 369);
            label7.Name = "label7";
            label7.Size = new Size(195, 18);
            label7.TabIndex = 12;
            label7.Text = "Enter your budget (in leva):";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // bud
            // 
            bud.AcceptsReturn = true;
            bud.BorderStyle = BorderStyle.FixedSingle;
            bud.Cursor = Cursors.IBeam;
            bud.Location = new Point(134, 411);
            bud.Name = "bud";
            bud.Size = new Size(137, 23);
            bud.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(502, 424);
            button1.Name = "button1";
            button1.Size = new Size(168, 32);
            button1.TabIndex = 14;
            button1.Text = "Add trip to profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // act
            // 
            act.Location = new Point(301, 289);
            act.Name = "act";
            act.Size = new Size(100, 23);
            act.TabIndex = 15;
            // 
            // city
            // 
            city.Location = new Point(301, 196);
            city.Name = "city";
            city.Size = new Size(100, 23);
            city.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(301, 157);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 16;
            label8.Text = "City/place name:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Font = new Font("HP Simplified", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(289, 452);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEditTrip_Click;
            // 
            // button3
            // 
            button3.Font = new Font("HP Simplified", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(380, 452);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDeleteTrip_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(39, 37);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.home_header_image_1200wx500h_norway_01;
            ClientSize = new Size(829, 497);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(city);
            Controls.Add(label8);
            Controls.Add(act);
            Controls.Add(button1);
            Controls.Add(bud);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Destination);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox Destination;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private TextBox bud;
        private Button button1;
        private TextBox act;
        private TextBox city;
        private Label label8;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}