using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace б13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //добавляю строки для таблицы
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();

            //создаю матрицу 3 на 4
            int[,] A = new int[5, 4];

            //формирую матрицу
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    A[i, j] = rnd.Next(0, 100); //диапазон занчений от 0 до 100
                }
            }

            //отображаю данные в dataGridView
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);
                }
            }

           //нахожу элементы главной диагонали

            int[] B = new int[4]; ;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        B[j] = A[i, j];
                    }
                }
            }
            //нахожу минимальный элемент
            int min = B.Min();

             //вывожу результат 
            textBox1.Text = min.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
