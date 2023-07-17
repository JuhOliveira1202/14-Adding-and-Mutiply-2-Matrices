using System;

class Program
{
    //soma e multiplicação de duas matrizes
    public static void Main(string[] args)
    {
        int l, c; //linha coluna

        int[,] ma = new int[2, 2]; // ler a 1ª Matriz 
        Console.WriteLine("Matriz A");

        for (l = 0; l < 2; l++)
        {
            for (c = 0; c < 2; c++)
            {

                Console.Write("Digite a posição " + l + "," + c + ":");
                ma[l, c] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        int[,] mb = new int[2, 2]; //ler a 2ª Matriz 
        Console.WriteLine("Matriz B");

        for (l = 0; l < 2; l++)
        {
            for (c = 0; c < 2; c++)
            {

                Console.Write("Digite a posição " + l + "," + c + ":");
                mb[l, c] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        //soma de duas matrizes 
        int[,] mc = new int[2, 2];
        Console.WriteLine("Soma das Matrizes");
        Console.WriteLine();

        for (l = 0; l < 2; l++)
        {
            for (c = 0; c < 2; c++)
            {
                Console.Write(mc[l, c] = ma[l, c] + mb[l, c]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        //multiplicação das matrizes
        Console.WriteLine("Multiplicação das Matrizes"); 
        Console.WriteLine();

        int soma = 0;
        for (l = 0; l < 2; l++)
        {
            for (c = 0; c < 2; c++)
            {
                for (int i = 0; i < 2; i++)
                {
                    soma = soma + (ma[l, i] + mb[i, c]);
                    Console.Write(soma);
                }
                Console.WriteLine();
            }
        }
    }
}
