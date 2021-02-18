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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            this.Hide();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f4 = new Form8();
            this.Hide();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f4 = new Form10();
            this.Hide();
            f4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 f4 = new Form11();
            this.Hide();
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form12 f4 = new Form12();
            this.Hide();
            f4.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 f4 = new Form13();
            this.Hide();
            f4.ShowDialog();
        }

   

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form14 f5 = new Form14();
            this.Hide();
            f5.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form15 f5 = new Form15();
            this.Hide();
            f5.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form16 f3 = new Form16();
            this.Hide();
            f3.ShowDialog();
        }
    }
}
