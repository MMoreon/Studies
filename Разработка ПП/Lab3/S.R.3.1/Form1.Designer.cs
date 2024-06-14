namespace S.R._3._1
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
            menuStrip1 = new MenuStrip();
            параметрыТекстаToolStripMenuItem = new ToolStripMenuItem();
            размерШрифтаToolStripMenuItem = new ToolStripMenuItem();
            крупныйToolStripMenuItem = new ToolStripMenuItem();
            среднийToolStripMenuItem = new ToolStripMenuItem();
            мелкийToolStripMenuItem = new ToolStripMenuItem();
            цветToolStripMenuItem = new ToolStripMenuItem();
            чёрныйToolStripMenuItem = new ToolStripMenuItem();
            красныйToolStripMenuItem = new ToolStripMenuItem();
            синийToolStripMenuItem = new ToolStripMenuItem();
            зеленыйToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { параметрыТекстаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(355, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // параметрыТекстаToolStripMenuItem
            // 
            параметрыТекстаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { размерШрифтаToolStripMenuItem, цветToolStripMenuItem });
            параметрыТекстаToolStripMenuItem.Name = "параметрыТекстаToolStripMenuItem";
            параметрыТекстаToolStripMenuItem.Size = new Size(120, 20);
            параметрыТекстаToolStripMenuItem.Text = "Параметры текста";
            // 
            // размерШрифтаToolStripMenuItem
            // 
            размерШрифтаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { крупныйToolStripMenuItem, среднийToolStripMenuItem, мелкийToolStripMenuItem });
            размерШрифтаToolStripMenuItem.Name = "размерШрифтаToolStripMenuItem";
            размерШрифтаToolStripMenuItem.Size = new Size(162, 22);
            размерШрифтаToolStripMenuItem.Text = "Размер шрифта";
            // 
            // крупныйToolStripMenuItem
            // 
            крупныйToolStripMenuItem.Name = "крупныйToolStripMenuItem";
            крупныйToolStripMenuItem.Size = new Size(124, 22);
            крупныйToolStripMenuItem.Text = "Крупный";
            крупныйToolStripMenuItem.Click += крупныйToolStripMenuItem_Click;
            // 
            // среднийToolStripMenuItem
            // 
            среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            среднийToolStripMenuItem.Size = new Size(124, 22);
            среднийToolStripMenuItem.Text = "Средний";
            среднийToolStripMenuItem.Click += среднийToolStripMenuItem_Click;
            // 
            // мелкийToolStripMenuItem
            // 
            мелкийToolStripMenuItem.Name = "мелкийToolStripMenuItem";
            мелкийToolStripMenuItem.Size = new Size(124, 22);
            мелкийToolStripMenuItem.Text = "Мелкий";
            мелкийToolStripMenuItem.Click += мелкийToolStripMenuItem_Click;
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { чёрныйToolStripMenuItem, красныйToolStripMenuItem, синийToolStripMenuItem, зеленыйToolStripMenuItem });
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new Size(162, 22);
            цветToolStripMenuItem.Text = "Цвет";
            // 
            // чёрныйToolStripMenuItem
            // 
            чёрныйToolStripMenuItem.Name = "чёрныйToolStripMenuItem";
            чёрныйToolStripMenuItem.Size = new Size(123, 22);
            чёрныйToolStripMenuItem.Text = "Чёрный";
            чёрныйToolStripMenuItem.Click += чёрныйToolStripMenuItem_Click;
            // 
            // красныйToolStripMenuItem
            // 
            красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            красныйToolStripMenuItem.Size = new Size(123, 22);
            красныйToolStripMenuItem.Text = "Красный";
            красныйToolStripMenuItem.Click += красныйToolStripMenuItem_Click;
            // 
            // синийToolStripMenuItem
            // 
            синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            синийToolStripMenuItem.Size = new Size(123, 22);
            синийToolStripMenuItem.Text = "Синий";
            синийToolStripMenuItem.Click += синийToolStripMenuItem_Click;
            // 
            // зеленыйToolStripMenuItem
            // 
            зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            зеленыйToolStripMenuItem.Size = new Size(123, 22);
            зеленыйToolStripMenuItem.Text = "Зеленый";
            зеленыйToolStripMenuItem.Click += зеленыйToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 93);
            label1.Name = "label1";
            label1.Size = new Size(89, 16);
            label1.TabIndex = 1;
            label1.Text = "Добрый день!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(355, 229);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 254);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Меню";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крупныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мелкийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чёрныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}
