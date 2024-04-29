namespace FinalProjectTravel
{
    partial class Yourtrips
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(573, 201);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("HP Simplified Hans", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 63);
            label2.Name = "label2";
            label2.Size = new Size(204, 35);
            label2.TabIndex = 8;
            label2.Text = "View your trips";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(369, 393);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Yourtrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.home_header_image_1200wx500h_norway_01;
            ClientSize = new Size(817, 458);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Yourtrips";
            Text = "Yourtrips";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button button4;
    }
}