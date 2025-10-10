namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Bill_Data
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 129);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 0;
            label1.Text = "Customer_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 26);
            label2.TabIndex = 1;
            label2.Text = "Bill_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 26);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 265);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 26);
            label4.TabIndex = 3;
            label4.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(177, 129);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(177, 263);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(177, 172);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 31);
            textBox3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.Location = new Point(123, 217);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(87, 376);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 8;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1089, 100);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(124, 49);
            button2.TabIndex = 9;
            button2.Text = "View data";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 112);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(694, 482);
            dataGridView1.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.Olive;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(13, 26);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(118, 46);
            button3.TabIndex = 11;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(570, 26);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(236, 53);
            label5.TabIndex = 13;
            label5.Text = "BILL DATA";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8;
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 675);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Bill_Data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Bill_Data";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill_Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label5;
        private PictureBox pictureBox1;
    }
}