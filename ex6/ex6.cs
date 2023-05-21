using System;

public class Program 
{
    public static void Main(string[] args)
    {
                  /* Crie um programa que leia uma matriz 3x3 de números inteiros do usuário.
                     Em seguida, calcule e exiba a soma de todos os elementos da matriz. */
         
             int[,] matriz = new int[3, 3];
             int soma=0;
            
             Console.WriteLine("Informe os Elementos da matriz 3x3");

             // Loop para preencher a matriz

                  for(int i=0;i<3;i++)
                     {
                        for (int j=0;j<3;j++)
                        {
                               Console.Write("Digite o elemento" + i + "," + j + " da matriz ");
                               matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                      }

            // Loop para somar os elementos da matriz 

               for(int i=0;i<3;i++)
                 {
                     for (int j=0;j<3;j++)
                    {
                        soma=soma+matriz[i, j];
                    }
                 }
                      Console.WriteLine("\nA soma dos elementos da matriz é: " + soma);
    } 
}