namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Category_Data
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
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 140);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 0;
            label1.Text = "Category_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 26);
            label2.TabIndex = 1;
            label2.Text = "Category_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 128);
            label3.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(183, 187);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 31);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "category 01", "category 02", "category 03", "category 04" });
            comboBox1.Location = new Point(183, 140);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Location = new Point(37, 263);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(314, 214);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1100, 91);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 7;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(243, 541);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(128, 46);
            button2.TabIndex = 8;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 100);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(647, 551);
            dataGridView1.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(13, 23);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(115, 46);
            button3.TabIndex = 10;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(13, 541);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(145, 46);
            button4.TabIndex = 11;
            button4.Text = "forward";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(537, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(362, 53);
            label4.TabIndex = 12;
            label4.Text = "CATEGORY DATA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 740);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Category_Data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Category_Data";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category_Data";
            Load += Category_Data_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Label label4;
        private PictureBox pictureBox1;
    }
}