namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Supplier_dashboard
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(15, 155);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(208, 54);
            button1.TabIndex = 0;
            button1.Text = "view stocks";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 239);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(736, 482);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(829, 239);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(222, 51);
            button2.TabIndex = 2;
            button2.Text = "Transactions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(829, 339);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(222, 46);
            button3.TabIndex = 3;
            button3.Text = "Handle stocks";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSalmon;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(829, 422);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(222, 82);
            button4.TabIndex = 4;
            button4.Text = "handle products";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSalmon;
            button5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(829, 578);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(141, 56);
            button5.TabIndex = 5;
            button5.Text = "back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(376, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(501, 53);
            label1.TabIndex = 6;
            label1.Text = "SUPPLIER DASHBOARD";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._17;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1255, 740);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Supplier_dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Supplier_dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier_dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}