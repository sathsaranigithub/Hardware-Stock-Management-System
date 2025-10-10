namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Transactions
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            label7 = new Label();
            button3 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(14, 325);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(364, 43);
            button1.TabIndex = 0;
            button1.Text = "view transaction details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 393);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1223, 315);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(534, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 33);
            label1.TabIndex = 2;
            label1.Text = "Transaction_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(534, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(240, 33);
            label2.TabIndex = 3;
            label2.Text = "Transaction_Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 128);
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(534, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 33);
            label3.TabIndex = 4;
            label3.Text = "Product_ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 128);
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(534, 272);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 33);
            label4.TabIndex = 5;
            label4.Text = "Customer_ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 128);
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(930, 267);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 33);
            label5.TabIndex = 6;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 128);
            label6.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(957, 208);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 33);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(804, 83);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.Location = new Point(804, 142);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(311, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(1081, 267);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Info;
            textBox5.Location = new Point(1081, 203);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 31);
            textBox5.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(760, 325);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(126, 43);
            button2.TabIndex = 14;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Tan;
            label7.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(26, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(388, 53);
            label7.TabIndex = 15;
            label7.Text = "Transaction DATA";
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(184, 125);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(180, 48);
            button3.TabIndex = 16;
            button3.Text = "Go To Bill data";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Info;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(726, 207);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 33);
            comboBox2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(726, 270);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 19;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSalmon;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(209, 208);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(119, 52);
            button4.TabIndex = 20;
            button4.Text = "home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.Image = Properties.Resources._8;
            pictureBox1.Location = new Point(-11, -13);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 752);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._8;
            pictureBox2.Location = new Point(657, -13);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(603, 752);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(1081, 332);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(107, 38);
            button5.TabIndex = 23;
            button5.Text = "Generate";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Transactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox5;
        private Button button2;
        private Label label7;
        private Button button3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button5;
    }
}