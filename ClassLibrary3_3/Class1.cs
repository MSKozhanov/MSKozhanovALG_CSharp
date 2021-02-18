using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace ClassLibrary3_3
{
    public class Class1
    {


        /// Генерация случайных чисел массива
        public static void enter_mas(int n, params double[] masPtr)
        {

            Random a = new Random();
            for (int i = 0; i < n; i++)
                masPtr[i] = (double)(a.Next() % 900) / 20 - 20;





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
        public static void set_mas(int n,ref double maximum, double[] masPtr, params double[] rezmasPtr)
        {
            int j = 0;
            for (int i = 0; i < n; i++)
                if (masPtr[i] < maximum)
                {
                    rezmasPtr[j] = masPtr[i];
                    j++;
                }
        }
        // Метод  add() предназначен для создания базы данных на диске
        public static void add()
        {
            var k = new ADOX.Catalog();
            try
            { 
                k.Create("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Database1.mdb");
                MessageBox.Show("База данных успешно создана","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (System.Runtime.InteropServices.COMException sit)
            {
                MessageBox.Show(sit.Message);
            }
            finally
            {
                k = null;
            }
        }
        //Метод add_struct() предназначен для формирования структуры базы данных
        public static void add_struct()
        {
            
            var p = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.CurrentDirectory + "\\Database1.mdb");
            p.Open();
            var c = new OleDbCommand("CREATE TABLE[Database1] ([Номер элемента] COUNTER,[Исходный массив] char(200)),[Результирующий массив] char(200))", p);
            try
            {
                c.ExecuteNonQuery();
                MessageBox.Show("Структура базы данных успешно создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception sit)
            {
                MessageBox.Show(sit.Message);
            }
            p.Close();
        }
        //Метод add_zap() предназначен для записи  в таблицу базы данных информации
        public static void add_zap(ref double[] masPtr, ref double[] rezmasPtr, int n, int k)
        {
            for(int i = 0; i < n; i++)
            {
                var p = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "\\Database1.mdb");
                p.Open();
                if (i < k)
                {
                    var c = new OleDbCommand("INCERT INTO [Database1](" + "[Исходный массив],[Результирующий массив]) VALUES('" + masPtr[i] + "','" + rezmasPtr[i] + "')");
                    c.Connection = p;
                    c.ExecuteNonQuery();
                }
                else
                {
                    var c = new OleDbCommand("INCERT INTO [Database1](" + "[Исходный массив],[Результирующий массив]) VALUES('" + masPtr[i] + "','')");
                    c.Connection = p;
                    c.ExecuteNonQuery();

                }
              
            }
            MessageBox.Show("Информация в базу данных успешно добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}