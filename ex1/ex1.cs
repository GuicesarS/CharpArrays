using System;
public class program 
{
    public static void Main(string []args)
    {
        // Faça um programa para ler a nota da prova de 15 alunos e armazene num vetor, calcule e imprima a media geral
        
        int[] nota = new int[15];
        int media, totalnota = 0;
        for (int i=0;i<15;i++)
        {
            Console.WriteLine("Digite a nota do aluno" + (i+1) + " : ");
            nota[i]=Convert.ToInt32(Console.ReadLine());

            totalnota=totalnota+nota[i];
           
        }
             media=totalnota/15;
            Console.WriteLine("A media geral e : " + media);

    }
}
