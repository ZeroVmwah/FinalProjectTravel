namespace FinalProjectTravel
{
    partial class ActivitiesFilter
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
            weather = new ComboBox();
            Terrain = new ComboBox();
            TravelLength = new ComboBox();
            dataGridView1 = new DataGridView();
            checkIn = new Button();
            button1 = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuitActivity = new ComboBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // weather
            // 
            weather.FormattingEnabled = true;
            weather.Items.AddRange(new object[] { "", "Sunny", "Rainy", "Cloudy", "Snowy" });
            weather.Location = new Point(45, 140);
            weather.Name = "weather";
            weather.Size = new Size(121, 23);
            weather.TabIndex = 0;
            weather.SelectedIndexChanged += weather_SelectedIndexChanged;
            // 
            // Terrain
            // 
            Terrain.FormattingEnabled = true;
            Terrain.Items.AddRange(new object[] { "", "Beach", "Mountain", "Nature", "Urban" });
            Terrain.Location = new Point(183, 140);
            Terrain.Name = "Terrain";
            Terrain.Size = new Size(121, 23);
            Terrain.TabIndex = 1;
            Terrain.SelectedIndexChanged += terrain_SelectedIndexChanged;
            // 
            // TravelLength
            // 
            TravelLength.FormattingEnabled = true;
            TravelLength.Items.AddRange(new object[] { "", "Short (1-5 days)", "Medium (6 - 12 days)", "Long (>13 days)" });
            TravelLength.Location = new Point(322, 140);
            TravelLength.Name = "TravelLength";
            TravelLength.Size = new Size(121, 23);
            TravelLength.TabIndex = 2;
            TravelLength.SelectedIndexChanged += TravelLength_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(390, 152);
            dataGridView1.TabIndex = 3;
            // 
            // checkIn
            // 
            checkIn.BackColor = Color.Indigo;
            checkIn.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkIn.ForeColor = SystemColors.ControlLightLight;
            checkIn.Location = new Point(353, 378);
            checkIn.Name = "checkIn";
            checkIn.Size = new Size(106, 32);
            checkIn.TabIndex = 6;
            checkIn.Text = "Packing List";
            checkIn.UseVisualStyleBackColor = false;
            checkIn.Click += checkIn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(141, 378);
            button1.Name = "button1";
            button1.Size = new Size(106, 32);
            button1.TabIndex = 12;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(183, 37);
            label6.Name = "label6";
            label6.Size = new Size(219, 36);
            label6.TabIndex = 13;
            label6.Text = "Activities filter";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("HP Simplified Hans", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(45, 109);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 14;
            label1.Text = "Weather";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("HP Simplified Hans", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(183, 109);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 15;
            label2.Text = "Terrain";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("HP Simplified Hans", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(322, 109);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 16;
            label3.Text = "Length of trip";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("HP Simplified Hans", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(463, 109);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 18;
            label4.Text = "Activity name";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // SuitActivity
            // 
            SuitActivity.FormattingEnabled = true;
            SuitActivity.Items.AddRange(new object[] { "", "Swimming", "Hiking", "Nature Walk", "Camel Riding", "Museum Visit", "Cycling", "Fishing", "Surfing", "Zip Lining", "Snorkeling", "Snowboarding", "Wine Tasting", "Shopping", "Picnic", "Hiking", "Paddle Boarding", "Rafting", "Safari", "Cave Exploring", "Boat Tour", "Ice Skating", "Petting Zoo", "Aquarium Visit", "Zoo Safari", "Sledding", "Botanical Garden Tour", "Theater Show", "Go Karting", "Skiing" });
            SuitActivity.Location = new Point(463, 140);
            SuitActivity.Name = "SuitActivity";
            SuitActivity.Size = new Size(121, 23);
            SuitActivity.TabIndex = 17;
            SuitActivity.SelectedIndexChanged += SuitActivity_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(26, 37);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ActivitiesFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = Properties.Resources.image_7__2_;
            ClientSize = new Size(596, 445);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(SuitActivity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(checkIn);
            Controls.Add(dataGridView1);
            Controls.Add(TravelLength);
            Controls.Add(Terrain);
            Controls.Add(weather);
            Name = "ActivitiesFilter";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox weather;
        private ComboBox Terrain;
        private ComboBox TravelLength;
        private DataGridView dataGridView1;
        private Button checkIn;
        private Button button1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox SuitActivity;
        private Button button4;
    }
}