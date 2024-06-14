namespace Lab2._2
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(47, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Сэндвич";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(223, 83);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 21);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Чай";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(47, 127);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(133, 21);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Картофель-фри";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(223, 127);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(63, 21);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Кофе";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(47, 174);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(58, 21);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Соус";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(223, 174);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(90, 21);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Coca-cola";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(47, 228);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(149, 21);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Дисконтная карта";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 36);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 7;
            label1.Text = "Ваш заказ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 268);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(223, 226);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 9;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(353, 352);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 254);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Кафе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}