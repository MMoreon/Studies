using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L.R._4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /* Создаем элементы списка comboBox для второй
            колонки:(не забудьте, индексация строк и столбцов
            начинается с нуля) */
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]
            ).Items.AddRange(new string[] { "ПИНб-21а", "ПИНб-21б" });
            // Задаем цвет фона компонента:
            dataGridView1.BackgroundColor = this.BackColor;
            // Убираем рамку:
            dataGridView1.BorderStyle = BorderStyle.None;
            // Задаем размеры таблицы:
            dataGridView1.Width = 700;
            dataGridView1.Height = 160;
            // Создаем вертикальную полосу прокрутки:
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            // Задаем выравнивание текста в ячейках по центру:
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i, countOne = 0 , countTwo = 0;
            // Если у нас 5 начальных колонок, формируем еще одну
            if (dataGridView1.ColumnCount == 5)
                dataGridView1.Columns.Add("Column5","Допуск к экзамену");
            dataGridView1.Columns[5].Width = 140;
            for (i = 0; i < dataGridView1.RowCount; i++)
                /* Проверка по флагу*/
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value) == true
                    && Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value) == true
                    && Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value) == true)
                { 
                    // Если все сдано- пишем «Допущен» и
                    // закрашиваем строку:
                    dataGridView1.Rows[i].Cells[5].Value = "Допущен";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) == "ПИНб-21а")
                    {
                        countOne += 1;
                    }
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) == "ПИНб-21б")
                    {
                        countTwo += 1;
                    }
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value = "";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            label2.Text = "В группе ПИНб-21а допущено: " + Convert.ToString(countOne);
            label3.Text = "В группе ПИНб-21б допущено: " + Convert.ToString(countTwo);

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

    

