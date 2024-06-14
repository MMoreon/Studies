namespace Lab._5._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 172);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(318, 24);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 1;
            button1.Text = "Задать шрифт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(318, 53);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 2;
            button2.Text = "Задать фон";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(13, 221);
            button3.Name = "button3";
            button3.Size = new Size(299, 23);
            button3.TabIndex = 3;
            button3.Text = "Обработать выделенный фрагмент текста";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(318, 299);
            button4.Name = "button4";
            button4.Size = new Size(104, 23);
            button4.TabIndex = 4;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(318, 328);
            button5.Name = "button5";
            button5.Size = new Size(104, 23);
            button5.TabIndex = 5;
            button5.Text = "Выход";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 5);
            label1.Name = "label1";
            label1.Size = new Size(87, 16);
            label1.TabIndex = 6;
            label1.Text = "Введите текст";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 198);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 20);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Выделить весь текст";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 257);
            label2.Name = "label2";
            label2.Size = new Size(123, 16);
            label2.TabIndex = 8;
            label2.Text = "Количество цифр: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 257);
            label3.Name = "label3";
            label3.Size = new Size(120, 16);
            label3.TabIndex = 9;
            label3.Text = "Количество букв: 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 273);
            label4.Name = "label4";
            label4.Size = new Size(132, 16);
            label4.TabIndex = 10;
            label4.Text = "Знаков препинания: 0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 273);
            label5.Name = "label5";
            label5.Size = new Size(148, 16);
            label5.TabIndex = 11;
            label5.Text = "Количество пробелов: 0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 302);
            label6.Name = "label6";
            label6.Size = new Size(41, 16);
            label6.TabIndex = 12;
            label6.Text = "Найти";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(432, 366);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Обработка текста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
