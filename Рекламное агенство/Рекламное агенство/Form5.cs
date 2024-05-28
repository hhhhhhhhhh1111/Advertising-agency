using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рекламное_агенство
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ночка f2 = new ночка();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сотрудника", "Сотрудник 4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сотрудника", "Сотрудник 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сотрудника", "Сотрудник 3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сотрудника", "Сотрудник 1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сотрудника", "Сотрудник 5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные сотрудника", "Сотрудник 6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сотрудник успешно зарегистрирован", "Регистрация сотрудника");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сотрудник успешно удален", "Удаление сотрудника");
        }
    }
}
