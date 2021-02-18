using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3_2
{
    public class Class3_2
    {
        /// Генерация случайных чисел
     public static int enter_mas(int n, params double[] masPtr)
     {
            int nomber = 0;
            double Maximum = -9999999;
            Random a = new Random();
            for (int i = 0; i < n; i++)
            { masPtr[i] = (double)(a.Next() % 900) / 20 - 20;
                if (masPtr[i] > Maximum)
                    Maximum = masPtr[i];
                    nomber = i + 1;
            }
            return nomber;
            
     }
        /// Вывод массива
     public static void output_mas(int len, System.Windows.Forms.DataGridView grid, params double[] aPtz)
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
            if (Width > 500)
                grid.Width = 500;
            else
                grid.Width = Width;
     }
     


    }

    
}
