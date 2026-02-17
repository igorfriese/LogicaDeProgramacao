using System;

class Exercicios
{

    static void Main(string[] args)
    {
        int X, Y;
        double total;

        string[] vet = Console.ReadLine().Split(' ');
        X = int.Parse(vet[0]);
        Y = int.Parse(vet[1]);

        switch (X)
        {
            case 1:
                total = Y * 4.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2")); 
                break;
            case 2:
                total = Y * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;
            case 3:
                total = Y * 5.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;
            case 4:
                total = Y * 2.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;
            case 5:
                total = Y * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
                break;
            default: 
                Console.WriteLine("Codigo invalido");
                break;
        }
    }

}