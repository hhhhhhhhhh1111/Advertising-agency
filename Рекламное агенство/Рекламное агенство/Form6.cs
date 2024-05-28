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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ночка f2 = new ночка();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные клиента", "Клиент 1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные клиента", "Клиент 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные клиента", "Клиент 3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные клиента", "Клиент 4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные клиента", "Клиент 5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данные клиента", "Клиент 6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клиент успешно зарегистрирован", "Регистрация клиента");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клиент успешно удалён", "Удаление клиента");
        }
    }
}
