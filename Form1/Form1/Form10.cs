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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, y1, a1, b1;
            double res = 0;
            int nomer_vetki = 0;
            x1 = ClassLibrary2.Class1.vvod(textBox1);
            y1 = ClassLibrary2.Class1.vvod(textBox2);
            a1 = ClassLibrary2.Class1.vvod(textBox3);
            b1 = ClassLibrary2.Class1.vvod(textBox5);
            ClassLibrary2.Class1.func1(x1, y1, b1, a1, ref nomer_vetki, ref res);
            ClassLibrary2.Class1.vivod(textBox4, res);
            ClassLibrary2.Class1.vivod(textBox6, nomer_vetki);
        }
    }
}
