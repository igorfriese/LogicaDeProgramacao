using System;
using System.Globalization;


namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int n1 = int.Parse(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine());
            // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // string[] v = Console.ReadLine().Split(' ');

            // string nome = v[0];
            // char sexo = char.Parse(v[1]);
            // int idade = int.Parse(v[2]);
            // double altura = double.Parse(v[3], CultureInfo.InvariantCulture);

            // Console.WriteLine(n1);
            // Console.WriteLine(ch);
            // Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); 

            // Console.WriteLine(nome + " " + sexo + " " + idade + " " + altura.ToString("F2", CultureInfo.InvariantCulture));

            // ex1 ---

            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');

            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
