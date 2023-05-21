using System;
public class program 
{
    public static void Main(string []args)
    {
        //Crie um programa que leia 5 números inteiros do usuário e armazene-os
        //em um vetor. Em seguida, exiba os números na ordem inversa em que foram digitados.

        int [] vetor = new int [5];
        int [] inverso = new int [5];

         for (int i=0; i<5;i++)
         {
            Console.WriteLine("Digite o numero" + (i+1) + ":");
            vetor[i]=Convert.ToInt32(Console.ReadLine());
         }

         Console.WriteLine("Ordem Inversa :");
         
         for(int i=4;i>=0;i--)
         {
            Console.Write(vetor[i] + " "); //não há quebra de linha adicionada automaticamente. Dessa forma, os valores são exibidos na mesma linha separados por espaços
         }

    }
}