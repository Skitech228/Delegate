using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        delegate double[] func(int a, int b);
        static void Main(string[] args)
        {
            РисовательТаблиц рисователь = new РисовательТаблиц();
            Console.WriteLine("Введите а,б");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            func funct = рисователь.Sinn;
            funct += рисователь.SinAndCos;
            funct += рисователь.x;
            double[] u;
            foreach (var item in funct.GetInvocationList())
            {
                u=(double[])item.DynamicInvoke(a, b);
                for (int i = 0; i < u.Length; i++)
                {
                    Console.Write(u[i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
