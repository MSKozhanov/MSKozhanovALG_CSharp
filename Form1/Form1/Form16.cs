﻿using Microsoft.VisualBasic;
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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1);
            int n = Convert.ToInt16(g);
           
            double[] masPtr = new double[n];
            ClassLibrary4.Class1.enter_mas(n, ref masPtr);
            ClassLibrary4.Class1.output_mas(n, grid, masPtr);
            String z = Interaction.InputBox("Введите индекс который хотите удалить", "Введите значение", "", -1);
            int ind = Convert.ToInt16(z);
            ClassLibrary4.Class1.udalenie(ref masPtr, ind);
            ClassLibrary4.Class1.output_mas(n-1, grid2, masPtr);
            ClassLibrary4.Class1.simple_choice(n, ref masPtr);
            ClassLibrary4.Class1.output_mas(n-1, dataGridView2, masPtr);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double f;
            String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1);
            int n = Convert.ToInt16(g);
            double[] masPtr = new double[n];
            ClassLibrary4.Class1.enter_mas(n, ref masPtr);
            ClassLibrary4.Class1.output_mas(n, grid5, masPtr);
            f = ClassLibrary4.Class1.monoton(n, ref masPtr);
            MessageBox.Show(f.ToString("n"), "1-да 0-нет", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1);
            int n = Convert.ToInt16(g);
            double [] masPtr = new double[n];
            ClassLibrary4.Class1.enter_mas(n, ref masPtr);
            ClassLibrary4.Class1.output_mas(n, grid6, masPtr);
            ClassLibrary4.Class1.find_first_otric(n, ref masPtr);
            ClassLibrary4.Class1.simple_insertion(n, ref masPtr);
            ClassLibrary4.Class1.output_mas(n, grid10, masPtr);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1);
            int n = Convert.ToInt16(g);
            double[] masPtr = new double[n];
            ClassLibrary4.Class1.enter_mas(n, ref masPtr);
            ClassLibrary4.Class1.output_mas(n, grid22, masPtr);
            String z = Interaction.InputBox("После какого элемента хотите добавить?", "Введите значение", "", -1);
            int k = Convert.ToInt16(z);
            String l = Interaction.InputBox("Какой элемент вы хотите добавить?", "Введите значение", "", -1);
            double m = Convert.ToDouble(l);
            ClassLibrary4.Class1.vstavka(k, m, ref masPtr);
            ClassLibrary4.Class1.output_mas(n + 1, grid33, masPtr);
            ClassLibrary4.Class1.binary_insertion(n, ref masPtr);
            ClassLibrary4.Class1.output_mas(n + 1, dataGridView1, masPtr);
        }

      

       
    }
}
