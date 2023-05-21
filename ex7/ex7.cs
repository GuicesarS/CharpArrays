using System;

public class Program 
{
    public static void Main(string[] args)
    {
        /* Crie um programa que leia duas matrizes 3x3 do usuário e realize a soma
           das duas matrizes. Em seguida, exiba a matriz resultante na tela. */

        int[,] matriz_a = new int[3, 3];
        int[,] matriz_b = new int[3, 3];
        int[,] resultante = new int[3, 3];

        Console.WriteLine("Informe a matriz A (3x3)");

        // Preencher a matriz a
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Digite o elemento [" + i + "," + j + "] da matriz");
                matriz_a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Informe a matriz B (3x3)");

        // Preencher a matriz b
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Digite o elemento [" + i + "," + j + "] da matriz");
                matriz_b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Somar as matrizes a e b
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultante[i, j] = matriz_a[i, j] + matriz_b[i, j];
            }
        }

        // Exibir a matriz resultante
        Console.WriteLine("Matriz Resultante:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultante[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
