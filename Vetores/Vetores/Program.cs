using System;
using System.Globalization;

/* int[] A;
 double[] B;
 string[] C;
 
 A = new int[10];
 B = new double[5];
 C = new string[8];
 
 // ACESSAR OS ELEMENTOS DE UM VETOR
 
 A[3] = 10;
 
 for (int i = 0; i<5; i++)
 {
     B[i] = i + 10;
 }
 

 int N;
 double[] vet;
 
 N = int.Parse(Console.ReadLine());
 vet = new double[N];
 
 for (int i = 0; i < N; i++)
 {
     vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 }
 
 for (int i = 0;i < N; i++)
 {
     Console.WriteLine(vet[i].ToString("F1"));
 } */

int N;
double[] vet; 

N = int.Parse(Console.ReadLine());
vet = new double[N];

string[] s = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
}

for (int i = 0;i < N; i++)
{
    Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}
Console.WriteLine();

double soma = 0.0;
for (int i = 0; i < N; i++)
{
    soma += vet[i];
}

double media = soma / N;

Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));