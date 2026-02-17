using System;
using System.Globalization;

namespace estruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXEMPLO WHILE

            // int X, Y;
            // 
            // string[] vet = Console.ReadLine().Split(' ');
            // X = int.Parse(vet[0]);
            // Y = int.Parse(vet[1]);
            // 
            // while (X != Y)
            // {
            //     if (X > Y) 
            //     {
            //         Console.WriteLine("Decrescente");
            //     }
            //     else 
            //     { 
            //         Console.WriteLine("Crescente");
            //     }
            //     vet = Console.ReadLine().Split(' ');
            //     X = int.Parse(vet[0]);
            //     Y = int.Parse(vet[1]);
            // }


            // exemplo2

            // double idade, soma, media;
            // int cont;
            // 
            // idade = int.Parse(Console.ReadLine());
            // soma = 0.0;
            // cont = 0;
            // 
            // while (idade >= 0)
            // {
            //     soma += idade;
            //     cont++;
            //     idade = int.Parse(Console.ReadLine());
            // }
            // 
            // if (cont == 0)
            // {
            //     Console.WriteLine("Impossível calcular");
            // }
            // else
            // {
            //     media = soma / cont;
            // 
            //     Console.WriteLine(media.ToString("F2"));
            // }

            // exemplo FOR

            // int N, x, soma;
            // 
            // N = int.Parse(Console.ReadLine());
            // soma = 0;
            // 
            // for (int i = 0; i < N; i++) 
            // { 
            //     x = int.Parse(Console.ReadLine());
            //     soma += x;
            // }
            // 
            // Console.WriteLine(soma);

            // ATIVIDADE BEECROWD

            // int X, Y, min, max, soma;
            // 
            // X = int.Parse(Console.ReadLine());
            // Y = int.Parse(Console.ReadLine());
            // 
            // if (X < Y)
            // {
            //     min = X;
            //     max = Y;
            // }
            // else
            // {
            //     min = Y;
            //     max = X;
            // }
            // 
            // soma = 0;
            // 
            // for (int i = min+1; i < max; i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         soma += i;
            //     }
            // }
            // 
            // Console.WriteLine(soma);

            // DO WHILE

            double C, F;
            char comando;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9 * C / 5 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                comando = char.Parse(Console.ReadLine());
            }
            while (comando == 's');

        }
    }
}