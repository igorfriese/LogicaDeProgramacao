using System;
using System.Globalization;
class Matrizes
{

    static void Main(string[] args)
    {
        // double[,] A;
        //
        // A = new double[3, 4];
        // A[1, 2] = 10;

        int M, N;
        string[] s1 = Console.ReadLine().Split(' ');
        M = int.Parse(s1[0]);
        N = int.Parse(s1[1]);

        int[,] A = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                A[i, j] = int.Parse(s[j]);  
            }
        }

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}