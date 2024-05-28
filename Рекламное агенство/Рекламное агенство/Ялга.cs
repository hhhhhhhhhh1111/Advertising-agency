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
    public partial class Ялга : Form
    {
        public Ялга()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                }
                else
                {
                    if (textBox2.Text == "1234") //password
                    {
                        if (textBox1.Text == "PoleAE") //login
                        {
                            this.Hide();
                            ночка f2 = new ночка();
                            f2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked)
                {
                    textBox2.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
