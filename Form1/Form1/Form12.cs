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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, xn, xk, dx, x = 0, t, summa = 0, tmult = 0;
            double tcolich = 0;
            a = ClassLibrary3_1.Class1.vvod(textBox1);
            xn = ClassLibrary3_1.Class1.vvod(textBox2);
            xk = ClassLibrary3_1.Class1.vvod(textBox3);
            dx = ClassLibrary3_1.Class1.vvod(textBox4);
            t = ClassLibrary3_1.Class1.funt(x,a);
            ClassLibrary3_1.Class1.Program( xn, xk,a, dx, ref summa, ref tcolich, ref tmult, dataGridView1);
            ClassLibrary3_1.Class1.vivod(textBox8, t);
            ClassLibrary3_1.Class1.vivod(textBox6, summa);
            ClassLibrary3_1.Class1.vivod(textBox5, tmult);
            ClassLibrary3_1.Class1.vivod(textBox7, tcolich);

        }


    }
}
