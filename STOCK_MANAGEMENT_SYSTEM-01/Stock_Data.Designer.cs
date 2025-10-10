namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Stock_Data
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(662, 87);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(139, 48);
            button1.TabIndex = 0;
            button1.Text = "view stocks";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 96);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(627, 500);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(693, 187);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 33);
            label1.TabIndex = 2;
            label1.Text = "stock_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(693, 247);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 33);
            label2.TabIndex = 3;
            label2.Text = "Product_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(693, 299);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 33);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(857, 191);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(857, 312);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 31);
            textBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(713, 460);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(290, 55);
            button2.TabIndex = 8;
            button2.Text = "Get Product_details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(915, 378);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(130, 48);
            button3.TabIndex = 9;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(857, 247);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSalmon;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(662, 378);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(129, 55);
            button4.TabIndex = 11;
            button4.Text = "back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaShell;
            label4.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(177, 9);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(279, 53);
            label4.TabIndex = 12;
            label4.Text = "STOCK DATA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._16;
            pictureBox1.Location = new Point(635, -7);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 677);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(740, 558);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(236, 38);
            button5.TabIndex = 14;
            button5.Text = "Generate";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Stock_Data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Stock_Data";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock_Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Button button4;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button5;
    }
}