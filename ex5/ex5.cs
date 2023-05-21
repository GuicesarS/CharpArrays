using System;

public class Program 
{
    public static void Main(string[] args)
    {
                  /*  5. Faça um programa que possua um vetor denominado A que armazene 6
            numeros inteiros. O programa deve executar os seguintes passos:
            a) Atribua os seguintes valores a esse vetor: 1, 0, 5, -2, -5, 7.
            b) Armazene em uma variável inteira (simples) a soma entre os valores das
            posições A[0], A[1] e A[5] do vetor e mostre na tela esta soma.
            (c) Modifique o vetor na posição 4, atribuindo a esta posição o valor 100.
            (d) Mostre na tela cada valor do vetor A, um em cada linha. */

         int [] vetor_a = {1,0,5,-2,-5,7};
         int soma_vetor=vetor_a[0]+vetor_a[1]+vetor_a[5];

         vetor_a[4]=vetor_a[4]+105;
         Console.WriteLine("O valor do elemento 4 do vetor apos a mudanca :"+ vetor_a[4]+ ".");
         Console.WriteLine("soma : "+ soma_vetor + ".");
         Console.WriteLine("Os Elementos do Vetor:");
         
         for (int i=0;i<6;i++)
         {

            Console.Write(vetor_a[i]);
            Console.Write("|");
         }

    }
}