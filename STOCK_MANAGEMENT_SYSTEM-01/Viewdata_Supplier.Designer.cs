namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Viewdata_Supplier
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
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(469, 143);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(321, 63);
            button1.TabIndex = 0;
            button1.Text = "view productdata";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BlanchedAlmond;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 260);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1096, 417);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(76, 73);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(96, 43);
            button2.TabIndex = 2;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._16;
            pictureBox1.Location = new Point(-6, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1254, 747);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1064, 73);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 4;
            button3.Text = "Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Viewdata_Supplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Viewdata_Supplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viewdata_Supplier";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}