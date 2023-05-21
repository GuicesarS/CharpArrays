using System;

public class Program 
{
    public static void Main(string[] args)
    {
        // Leia um vetor de 10 posições. Contar e escrever quantos valores pares ele possui
        int [] vetor = new int [10];
        int par=0;

        for (int i=0;i<10;i++)
        {
            Console.WriteLine("Informe o elemento" + (i+1) + " do vetor");
            vetor[i]=Convert.ToInt32(Console.Readline());
            
            if(vetor[i]%2==0)
            {
                par++;
            }
        }
          Console.WriteLine("A quantidade de valores pares são:" + par + ".");
    }
}