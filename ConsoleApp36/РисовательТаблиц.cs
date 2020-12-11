using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class РисовательТаблиц
    {
        public double[] Sinn(int a, int b)
        { int c=0;
            if (a > b)
                c = a - b;
            else
                c = b - a;
            double[] sinnys = new double[c];
            c = a;
            for (int i = 0; i < sinnys.Length; i++)
            {
                sinnys[i] = Math.Round(Math.Sin(c *Math.PI/180), 3);
                c++;
            }
            return sinnys;
        }

        public double[] SinAndCos(int a, int b)
        {
            int c = 0;
            if (a > b)
                c = a - b;
            else
                c = b - a;
            double[] sinnys = new double[c];
            double u = a;
            for (int i = 0; i < sinnys.Length; i++)
            {
                sinnys[i] = (Math.Pow(Math.Sin(u * 180 / Math.PI),2) + Math.Pow(Math.Cos(u * 180 / Math.PI), 2));
                u++;
            }
            return sinnys;
        }

        public double[] x(int a, int b)
        {
            int c = 0;
            if (a > b)
                c = a - b;
            else
                c = b - a;
            double[] sinnys = new double[c];
            c = a;
            for (int i = 0; i < sinnys.Length; i++)
            {
                try
                {
                    sinnys[i] = Math.Round((double)1/c,3);
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    sinnys[i] = 0;
                }
                c++;
            }
            return sinnys;
        }
    }
}
