using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;



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
                var c = new OleDbCommand("CREATE TABLE [Database1]([Номер элемента] COUNTER, [Исходный массив] char(200),[Результирующий массив] char(200))", p);
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
                        var c = new OleDbCommand("INSERT INTO [Database1](" + "[Исходный массив],[Результирующий массив]) VALUES('" + masPtr[i] + "','" + rezmasPtr[i] + "')");
                        c.Connection = p;
                        c.ExecuteNonQuery();
                    }
                    else
                    {
                        var c = new OleDbCommand("INSERT INTO [Database1](" + "[Исходный массив],[Результирующий массив]) VALUES('" + masPtr[i] + "','')");
                        c.Connection = p;
                        c.ExecuteNonQuery();

                    }

                }
                MessageBox.Show("Информация в базу данных успешно добавлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        //Запись в Excel
            public static void ZapisExcel(int n,  double[] masPtr, params double[] rezmasPtr)
            {
               
            
            
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workBook;
                Excel.Worksheet workSheet;
                workBook = excelApp.Workbooks.Add();
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
                workSheet.Name = "Массив исходный";
                workSheet.Cells[1, 1] = "Исходный массив";
                for (int i = 0; i < n; i++)
                {
                    workSheet.Cells[2, i + 1] = "[" + i + "]";
                    workSheet.Cells[3, i + 1] = masPtr[i];
                }
                workSheet.Cells[4, 1] = "Результирующий массив";
                for (int i = 0; i < n-1; i++)
                {
                    workSheet.Cells[5, i + 1] = "[" + i + "]";
                    workSheet.Cells[6, i + 1] = rezmasPtr[i];
                }
                // Форматировать первую строку
                Excel.Range range1 = workSheet.Range[workSheet.Cells[1, 1], workSheet.Cells[2, n]];
                range1.Cells.Font.Name = "Times new Roman";
                range1.Cells.Font.Size = 14;
                //Форматировать вторую строку
                Excel.Range range2 = workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[2, n]];
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range2.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;

                //Форматировать третью строку
                Excel.Range range3 = workSheet.Range[workSheet.Cells[3, 1], workSheet.Cells[2, n]];
                range3.Cells.Font.Name = "Times new Roman";
                range3.Cells.Font.Size = 14;
                range3.Cells.Columns.AutoFit();
                range3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range3.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range3.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range3.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
                // Форматировать четвертую строку
                Excel.Range range4 = workSheet.Range[workSheet.Cells[4, 1], workSheet.Cells[2, n]];
                range4.Cells.Font.Name = "Times new Roman";

                // Форматировать пятую строку
                Excel.Range range5 = workSheet.Range[workSheet.Cells[5, 1], workSheet.Cells[2, n - 1]];
                range5.Cells.Font.Name = "Times new Roman";
                range5.Cells.Font.Size = 14;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range5.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
                // Форматировать шестую строку
                Excel.Range range6 = workSheet.Range[workSheet.Cells[6, 1], workSheet.Cells[2, n - 1]];
                range6.Cells.Font.Name = "Times new Roman";
                range6.Cells.Font.Size = 14;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
                range6.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;

                workSheet.Range[("A8")].Select();
                excelApp.Visible = true;
                excelApp.UserControl = true;
            

            } 
    
  
    }
}