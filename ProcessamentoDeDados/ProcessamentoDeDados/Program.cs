using System;
using System.Globalization;


namespace ProcessamentoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;
          
            Console.WriteLine(area);

            Console.ReadLine();

            // CASTING ABAIXO

            double a;
            int c;

            a = 5.0;
            c = (int) a;

            Console.WriteLine(c);
        }
    }
}