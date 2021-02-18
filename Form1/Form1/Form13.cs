
using Microsoft.VisualBasic;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1);
            int n = Convert.ToInt16(g);
            double[] masPtr = new double[n];
            Array.Clear(masPtr, 0, masPtr.Length);
            double maximum = 0;
            int max_i;
            ClassLibrary3_3.Class1.enter_mas(n, masPtr);
            ClassLibrary3_3.Class1.output_mas(n, grid, masPtr);
            max_i = ClassLibrary3_3.Class1.max_mas(ref maximum, n, masPtr);
            MessageBox.Show("Номер максимального элемента =" + max_i.ToString("n"), "Номер", MessageBoxButtons.OK);




        }
    }
}
