﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar.Equals((char)13))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar.Equals((char)13))
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    if (!(e.KeyChar.ToString() == "," && textBox2.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    {
                        e.Handled = true;
                    }
                }
                if (e.KeyChar.Equals((char)13))
                {
                    button1.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chislo1, chislo2, chislo3, res1, res2;
            chislo1 = ClassLibrary3_1.Class1.vvod(textBox1);
            chislo2 = ClassLibrary3_1.Class1.vvod(textBox2);
            chislo3 = ClassLibrary3_1.Class1.vvod(textBox3);
            res1 = ClassLibrary3_1.Class1.primer_f(chislo1, chislo2);
            res2 = ClassLibrary3_1.Class1.primer_z(chislo3);
            ClassLibrary3_1.Class1.vivod(textBox4, res1);
            ClassLibrary3_1.Class1.vivod(textBox5, res2);
            MessageBox.Show("Ответ f = " + res1.ToString("n") + "   Ответ z = " + res2.ToString("n"), "Кожанов М.С",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
