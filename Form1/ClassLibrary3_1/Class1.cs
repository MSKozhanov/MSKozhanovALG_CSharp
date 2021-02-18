using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassLibrary3_1
{
    public class Class1
    {
        public static void funk(double x, double y, double z, double a, ref double r, ref int nom)
        {
            double min = 0;
            double max = 0;
            if (Math.Pow(Math.Abs(z), x * y) < 3)
            {
                r = Math.Sqrt(Math.Abs(z) + Math.Abs(y) + Math.Abs(z));
                nom = 1;
            }
            if (Math.Pow(Math.Abs(z), (x + y)) > 4)
            {
                min = Math.Sqrt(Math.Abs(x));
                if (Math.Sqrt(Math.Abs(y)) < min)
                {
                    min = Math.Sqrt(Math.Abs(y));
                }
                if (Math.Sqrt(Math.Abs(z)) < min)
                {
                    min = Math.Sqrt(Math.Abs(z));
                }
                r = min;
                nom = 2;

            }
            if (Math.Pow(Math.Abs(z), (x + y)) > 3 && Math.Pow(Math.Abs(z), (x + y)) < 4)
            {
                max = x;
                if (Math.Pow(y, 3) > max)
                {
                    max = Math.Pow(y, 3);
                }
                r = max + a;
                nom = 3;

            }
        }

        public static double primer_w(double a, double b, double x)
        {
            double w = Math.Cos(Math.Pow(x, 3)) * Math.Cos(Math.Pow(x, 3)) - (x / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));

            return w;
        }
        public static double primer_z(double a, double b, double x)
        {
            double z = Math.Sqrt((a * x * Math.Sin(2 * x) + Math.Exp((-2) * x)) * (x + b));
            return z;
        }
        public static double vvod(TextBox t)
        {
            return Convert.ToDouble(t.Text);
        }
        public static void vivod(TextBox t, double c)
        {
            t.Text = Convert.ToString(c);


        }
        public static double primer_f(double x, double y)
        {
            double f = (Math.PI / 3 + Math.Log((Math.Pow(x, 3)), Math.E) / 3 * y - x + x * Math.Sin(Math.Pow(y, 2)));

            return f;
        }
        public static double primer_z(double z)
        {
            double zz;
            int x, y, p, z2;
            z2 = (int)z;
            x = (z2 / 100) * 10;
            y = ((z2 / 10) % 10) * 100;
            p = z2 % 10;
            zz = y + x + p;

            return zz;
        }
        public static double fun(double x)
        {
            double y = (1 + Math.Cos(10 * x));
            return y;
        }
        public static void VivodDGV(double x, double y, DataGridView DGV)
        {
            DGV.Rows.Add(x.ToString("F1"), y.ToString("F5"));
        }
        public static double Proc(double x, double y, double a, double b, double h,  DataGridView DGV)
        {
            x = a;
            double summa = 0;
            
            int n = Convert.ToInt32(Math.Round(((b - a) / h) + 1));
            int i = 1;
            for (i = 1; i <= n; i++)
            {
                y = fun(x);
                summa  += y;
                VivodDGV(x, y, DGV);
                x += h;
               
            }
            return summa;
    
        }

        public static double funt(double a, double x)
        {
            double t = (Math.Sin(x*x) + 3.2)/(a + x * Math.Pow(Math.E,(a + x)));
            return t;
        }
        public static void VivodD(double t, double x, DataGridView DGV)
        {
            DGV.Rows.Add(t.ToString("F1"), x.ToString("F5"));
        }
        public static void Program( double xn, double xk, double a, double dx,ref double summa, ref double tcolich, ref double tmult, DataGridView DGV)
        {
            double mult = 1;
            double p = 0;
            double z = 0;
            double x = xn;
            double t = 0;


            while (x <= xk)
            {
             t = funt(a,x);
             VivodD(t, x, DGV);
                if (t > 0)
                    z += t;
                if (t < 0)
                    mult *= t;
             p += 1;
             x += dx;

            }
            summa = z;
            tcolich = p;
            tmult = mult;
           
        }



    }
}
