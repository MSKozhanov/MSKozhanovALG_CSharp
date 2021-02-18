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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x, y, a = 0.5, h = Math.PI / 16, b = 1.5, summa = 0;
            x = ClassLibrary3_1.Class1.vvod(textBox3);
            y = ClassLibrary3_1.Class1.fun(x);
            summa = ClassLibrary3_1.Class1.Proc(x,y, a, b, h, dataGridView1);
            ClassLibrary3_1.Class1.vivod(textBox1, y);
            ClassLibrary3_1.Class1.vivod(textBox2, summa);
           
        }
    }
}
