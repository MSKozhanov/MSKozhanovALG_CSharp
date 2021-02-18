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
using System.Data.OleDb;


namespace Form1
{
    public partial class Form14 : Form
    {
        

        public Form14()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1);
            int n = Convert.ToInt16(g);
            // Первый массив
            double[] masPtr = new double[n];

            // Первый массив заполнение и вывод в DGV
            Array.Clear(masPtr, 0, masPtr.Length);
            double maximum = 0;
            int max_i;
            //Генерация случайных чисел массива
            ClassLibrary3_3.Class1.enter_mas(n, masPtr);
            //Вывод исходного массива в DGV
            ClassLibrary3_3.Class1.output_mas(n, grid, masPtr);
            //Создание БД на диске
            ClassLibrary3_3.Class1.add();
            int k = 0;
            int j = 0;
            //Поиск максимального
            max_i = ClassLibrary3_3.Class1.max_mas(ref maximum, n, masPtr);
            MessageBox.Show("Номер максимального элемента =" + max_i.ToString("n"), "Номер", MessageBoxButtons.OK);
            //Счетчик
            ClassLibrary3_3.Class1.set_count(n, maximum, ref k, masPtr);
            double[] rezmasPtr = new double[k];
            //Результирующий массив
            ClassLibrary3_3.Class1.set_mas(n, ref maximum, masPtr, rezmasPtr);
            //Вывод результирующего массива в DGV
            ClassLibrary3_3.Class1.output_mas(k, grid2, rezmasPtr);
            //Создание структуры БД
            ClassLibrary3_3.Class1.add_struct();
            //Заполнение БД
            ClassLibrary3_3.Class1.add_zap(ref masPtr, ref rezmasPtr, n, k);

            

        }
    }
}
