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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1 = 0, y1 = 0, z1 = 0, a1 = 0;
            double r = 0;
            int nom = 0;
            x1 = ClassLibrary3_1.Class1.vvod(textBox1);
            y1 = ClassLibrary3_1.Class1.vvod(textBox2);
            z1 = ClassLibrary3_1.Class1.vvod(textBox3);
            a1 = ClassLibrary3_1.Class1.vvod(textBox4);

            ClassLibrary3_1.Class1.funk(x1, y1, z1, a1, ref r, ref nom);
            ClassLibrary3_1.Class1.vivod(textBox5, r);
            ClassLibrary3_1.Class1.vivod(textBox6, nom);


        }
    }
}
