namespace S.R._5._1
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
            TreeNode treeNode1 = new TreeNode("sbyte");
            TreeNode treeNode2 = new TreeNode("byte");
            TreeNode treeNode3 = new TreeNode("short");
            TreeNode treeNode4 = new TreeNode("ushort");
            TreeNode treeNode5 = new TreeNode("int");
            TreeNode treeNode6 = new TreeNode("uint");
            TreeNode treeNode7 = new TreeNode("long");
            TreeNode treeNode8 = new TreeNode("ulong");
            TreeNode treeNode9 = new TreeNode("Integral", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7, treeNode8 });
            TreeNode treeNode10 = new TreeNode("char");
            TreeNode treeNode11 = new TreeNode("Characters", new TreeNode[] { treeNode10 });
            TreeNode treeNode12 = new TreeNode("float");
            TreeNode treeNode13 = new TreeNode("double");
            TreeNode treeNode14 = new TreeNode("Floating", new TreeNode[] { treeNode12, treeNode13 });
            TreeNode treeNode15 = new TreeNode("decimal");
            TreeNode treeNode16 = new TreeNode("Decimal", new TreeNode[] { treeNode15 });
            TreeNode treeNode17 = new TreeNode("bool");
            TreeNode treeNode18 = new TreeNode("Boolean", new TreeNode[] { treeNode17 });
            TreeNode treeNode19 = new TreeNode("Simple types", new TreeNode[] { treeNode9, treeNode11, treeNode14, treeNode16, treeNode18 });
            TreeNode treeNode20 = new TreeNode("Enum types");
            TreeNode treeNode21 = new TreeNode("Struct types");
            TreeNode treeNode22 = new TreeNode("Nullable types");
            TreeNode treeNode23 = new TreeNode("Value types", new TreeNode[] { treeNode19, treeNode20, treeNode21, treeNode22 });
            TreeNode treeNode24 = new TreeNode("object");
            TreeNode treeNode25 = new TreeNode("string");
            TreeNode treeNode26 = new TreeNode("class");
            TreeNode treeNode27 = new TreeNode("Class types", new TreeNode[] { treeNode24, treeNode25, treeNode26 });
            TreeNode treeNode28 = new TreeNode("Interface types");
            TreeNode treeNode29 = new TreeNode("Array types");
            TreeNode treeNode30 = new TreeNode("Delegate types");
            TreeNode treeNode31 = new TreeNode("Reference types", new TreeNode[] { treeNode27, treeNode28, treeNode29, treeNode30 });
            TreeNode treeNode32 = new TreeNode("C# Data types", new TreeNode[] { treeNode23, treeNode31 });
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(15, 15);
            treeView1.Margin = new Padding(4, 3, 4, 3);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел12";
            treeNode1.Text = "sbyte";
            treeNode2.Name = "Узел13";
            treeNode2.Text = "byte";
            treeNode3.Name = "Узел14";
            treeNode3.Text = "short";
            treeNode4.Name = "Узел15";
            treeNode4.Text = "ushort";
            treeNode5.Name = "Узел16";
            treeNode5.Text = "int";
            treeNode6.Name = "Узел17";
            treeNode6.Text = "uint";
            treeNode7.Name = "Узел18";
            treeNode7.Text = "long";
            treeNode8.Name = "Узел19";
            treeNode8.Text = "ulong";
            treeNode9.Name = "Узел7";
            treeNode9.Text = "Integral";
            treeNode10.Name = "Узел20";
            treeNode10.Text = "char";
            treeNode11.Name = "Узел8";
            treeNode11.Text = "Characters";
            treeNode12.Name = "Узел21";
            treeNode12.Text = "float";
            treeNode13.Name = "Узел22";
            treeNode13.Text = "double";
            treeNode14.Name = "Узел9";
            treeNode14.Text = "Floating";
            treeNode15.Name = "Узел23";
            treeNode15.Text = "decimal";
            treeNode16.Name = "Узел10";
            treeNode16.Text = "Decimal";
            treeNode17.Name = "Узел24";
            treeNode17.Text = "bool";
            treeNode18.Name = "Узел11";
            treeNode18.Text = "Boolean";
            treeNode19.Name = "Узел3";
            treeNode19.Text = "Simple types";
            treeNode20.Name = "Узел4";
            treeNode20.Text = "Enum types";
            treeNode21.Name = "Узел5";
            treeNode21.Text = "Struct types";
            treeNode22.Name = "Узел6";
            treeNode22.Text = "Nullable types";
            treeNode23.Name = "Узел1";
            treeNode23.Text = "Value types";
            treeNode24.Name = "Узел29";
            treeNode24.Text = "object";
            treeNode25.Name = "Узел30";
            treeNode25.Text = "string";
            treeNode26.Name = "Узел31";
            treeNode26.Text = "class";
            treeNode27.Name = "Узел25";
            treeNode27.Text = "Class types";
            treeNode28.Name = "Узел26";
            treeNode28.Text = "Interface types";
            treeNode29.Name = "Узел27";
            treeNode29.Text = "Array types";
            treeNode30.Name = "Узел28";
            treeNode30.Text = "Delegate types";
            treeNode31.Name = "Узел2";
            treeNode31.Text = "Reference types";
            treeNode32.Name = "Узел0";
            treeNode32.Text = "C# Data types";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode32 });
            treeView1.Size = new Size(437, 337);
            treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(467, 367);
            Controls.Add(treeView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Иерархия типов данных C#";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}
