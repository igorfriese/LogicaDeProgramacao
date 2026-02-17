using System;
using System.Globalization;
class Foreach
{

    static void Main(string[] args)
    {
        int N;
        N = int.Parse(Console.ReadLine());
        string[] vet = new string[N];

        for (int i = 0; i < N; i++)
        {
            vet[i] = Console.ReadLine();
        }

        // Console.WriteLine("Nomes lidos:");
        // for (int i = 0; i < N; i++)
        // {
        //     Console.WriteLine(vet[i]);
        // }

        // FOREACH

        Console.WriteLine("Nomes lidos:");
        foreach (string elemento in vet) 
        {
            Console.WriteLine(elemento);
        }
    }
}