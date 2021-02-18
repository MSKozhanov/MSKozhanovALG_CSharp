using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                string my = "123";
                int Max_Try = 3;
                int tries = 1;
                string passwd = "   ";
                while ((passwd != my) && (tries <= Max_Try))
                {
                    passwd = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль", "Окно ввода данных", "", -1 - 1);
                    tries = tries + 1;

                }
                if (passwd == my)
                {
                    MessageBox.Show("Вы ввели правильный пароль... Доступ предоставлен", "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Добро пожаловать в программу...", "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 f = new Form2();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль... В доступе отказано", "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }

            }
        }
    }
}
