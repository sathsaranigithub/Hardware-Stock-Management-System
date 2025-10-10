namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Admin_dashboard
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(174, 224);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(290, 80);
            button2.TabIndex = 1;
            button2.Text = "Manage Suppliers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(174, 418);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(290, 75);
            button3.TabIndex = 2;
            button3.Text = "Manage Customers";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(557, 418);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(290, 80);
            button4.TabIndex = 3;
            button4.Text = "billpayments";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(557, 228);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(290, 76);
            button7.TabIndex = 6;
            button7.Text = "product_details";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(262, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(523, 61);
            label1.TabIndex = 7;
            label1.Text = "ADMIN  DASHBOARD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._71;
            pictureBox1.Location = new Point(-194, -43);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1444, 778);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1058, 664);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Admin_dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_dashboard";
            Load += Admin_dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Label label1;
        private PictureBox pictureBox1;
    }
}