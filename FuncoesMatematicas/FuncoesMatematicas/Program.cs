using System;
using System.Globalization;


namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double x = 3.0;
            // double y = 4.0;
            // double z = -5.0;
            // double A, B, C;

            // A = Math.Sqrt(x);
            // B = Math.Sqrt(y);
            // C = Math.Sqrt(25.0);
            // Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            // Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            // Console.WriteLine("Raiz quadrada de 25 = " + C);

            // A = Math.Pow(x, y);
            // B = Math.Pow(x, 2.0);
            // C = Math.Pow(5.0, 2.0);
            // Console.WriteLine(x + " elevado a " + y + " = " + A);
            // Console.WriteLine(x + " elevado ao quadrado = " + B);
            // Console.WriteLine("5 elevado ao quadrado = " + C);

            // A = Math.Abs(y);
            // B = Math.Abs(z);
            // Console.WriteLine("Valor absoluto de " + y + " = " + A);
            // Console.WriteLine("Valor absoluto de " + z + " = " + B);

            // EXERCICIO
            double largura, comprimento, valor, area, preco; 

            Console.WriteLine("Informe a largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor do metro quadrado:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * valor;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
