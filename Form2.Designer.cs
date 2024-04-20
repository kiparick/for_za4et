namespace ЛАБА10_ЗАДАНИЕ2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(405, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 35);
            label1.TabIndex = 1;
            label1.Text = "Дано:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(404, 47);
            label2.Name = "label2";
            label2.Size = new Size(43, 35);
            label2.TabIndex = 2;
            label2.Text = "R=";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(440, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(404, 82);
            label3.Name = "label3";
            label3.Size = new Size(44, 35);
            label3.TabIndex = 4;
            label3.Text = "U=";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(440, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(48, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(404, 120);
            label4.Name = "label4";
            label4.Size = new Size(84, 35);
            label4.TabIndex = 6;
            label4.Text = "Найти:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(405, 155);
            label5.Name = "label5";
            label5.Size = new Size(22, 35);
            label5.TabIndex = 7;
            label5.Text = "I";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(534, 12);
            label6.Name = "label6";
            label6.Size = new Size(107, 35);
            label6.TabIndex = 8;
            label6.Text = "Решение:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(534, 55);
            label7.Name = "label7";
            label7.Size = new Size(75, 35);
            label7.TabIndex = 9;
            label7.Text = "I=U/R";
            // 
            // button1
            // 
            button1.Location = new Point(615, 61);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Решить!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(534, 120);
            label8.Name = "label8";
            label8.Size = new Size(79, 35);
            label8.TabIndex = 11;
            label8.Text = "Ответ:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(615, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 27);
            textBox3.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(684, 131);
            label9.Name = "label9";
            label9.Size = new Size(54, 24);
            label9.TabIndex = 13;
            label9.Text = "Ампер";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(494, 58);
            label10.Name = "label10";
            label10.Size = new Size(32, 24);
            label10.TabIndex = 14;
            label10.Text = "Ом";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(494, 93);
            label11.Name = "label11";
            label11.Size = new Size(19, 24);
            label11.TabIndex = 15;
            label11.Text = "В";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 450);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Choice1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}