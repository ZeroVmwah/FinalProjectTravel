namespace FinalProjectTravel
{
    partial class PackingList
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
            dest = new TextBox();
            weth = new TextBox();
            dur = new TextBox();
            list = new TextBox();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("HP Simplified Hans", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 63);
            label1.Name = "label1";
            label1.Size = new Size(360, 35);
            label1.TabIndex = 7;
            label1.Text = "What do you want to bring?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("HP Simplified Hans", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(43, 192);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 8;
            label2.Text = "Destination";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("HP Simplified Hans", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(43, 236);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 9;
            label3.Text = "Weather";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("HP Simplified Hans", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(420, 143);
            label4.Name = "label4";
            label4.Size = new Size(102, 22);
            label4.TabIndex = 10;
            label4.Text = "Packing list";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("HP Simplified Hans", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(43, 286);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 11;
            label5.Text = "Duration";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // dest
            // 
            dest.Location = new Point(173, 191);
            dest.Name = "dest";
            dest.Size = new Size(153, 23);
            dest.TabIndex = 12;
            // 
            // weth
            // 
            weth.Location = new Point(173, 235);
            weth.Name = "weth";
            weth.Size = new Size(91, 23);
            weth.TabIndex = 13;
            // 
            // dur
            // 
            dur.Location = new Point(173, 285);
            dur.Name = "dur";
            dur.Size = new Size(81, 23);
            dur.TabIndex = 14;
            // 
            // list
            // 
            list.Location = new Point(362, 191);
            list.Multiline = true;
            list.Name = "list";
            list.Size = new Size(221, 203);
            list.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(119, 369);
            button1.Name = "button1";
            button1.Size = new Size(121, 35);
            button1.TabIndex = 16;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(508, 32);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // PackingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.home_header_image_1200wx500h_norway_01;
            ClientSize = new Size(653, 452);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(list);
            Controls.Add(dur);
            Controls.Add(weth);
            Controls.Add(dest);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PackingList";
            Text = "PackingList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox dest;
        private TextBox weth;
        private TextBox dur;
        private TextBox list;
        private Button button1;
        private Button button4;
    }
}