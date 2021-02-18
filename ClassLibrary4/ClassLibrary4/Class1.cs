using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary4
{
    public class Class1
    {
        /// ВТОРОЙ СЕМЕСТР
        public static void enter_mas(int n, ref double[] masPtr)
        {

            Random a = new Random();
            for (int i = 0; i < n; i++)
                masPtr[i] = (double)(a.Next() % 900) / 20 - 20;

        }
        public static void udalenie(ref double[] masPtr, int ind)
        {
            double[] newMasPtr = new double[masPtr.Length - 1];

            for (int i = 0; i < ind; i++)
                newMasPtr[i] = masPtr[i];

            for (int i = ind + 1; i < masPtr.Length; i++)
                newMasPtr[i - 1] = masPtr[i];

            masPtr = newMasPtr;
        }
        public static int monoton(int n, ref double[] masPtr)
        {
            int i = 0;
            int flag = 1;
            while ((i <= n -2)&&(flag ==1))
            {
                if (masPtr[i] >= masPtr[i + 1])
                {
                    i++;
                }
                else
                    flag = 0;
            }
            return flag;
        }
        /// Вывод массива и его индексов в DataGridView
        public static void output_mas(int len, DataGridView grid, params double[] aPtz)
        {
            grid.ColumnCount = len;
            grid.RowCount = 2;
            for (int i = 0; i < len; i++)
            {
                grid.Rows[0].Cells[i].Value = "[" + i + "]";
                grid.Rows[1].Cells[i].Value = aPtz[i];
            }
            int Width = 0;
            for (int s = 0; s < grid.ColumnCount; s++)
                Width += grid.Columns[s].Width;
            if (Width > 10000)
                grid.Width = 10000;
            else
                grid.Width = Width;
        }
        // Нахождение максимального элемента массива и вывод его номера
        public static int max_mas(ref double maximum, int n, double[] masPtr)
        {
            maximum = -99999;
            int max_index = 0;
            for (int i = 0; i < n; i++)
            {
                if (masPtr[i] > maximum)
                {

                    maximum = masPtr[i];
                    max_index = i + 1;

                }

            }
            return max_index;
        }
        // Счетчик
        public static void set_count(int n, double maximum, ref int k, params double[] masPtr)
        {
            for (int i = 0; i < n; i++)
                if (masPtr[i] < maximum)
                    k++;
        }
        // Создание результирующего массива
        public static void set_mas(int n, ref double maximum, double[] masPtr, params double[] rezmasPtr)
        {
            int j = 0;
            for (int i = 0; i < n; i++)
                if (masPtr[i] < maximum)
                {
                    rezmasPtr[j] = masPtr[i];
                    j++;
                }
        }
    }
}
