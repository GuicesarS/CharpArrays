using System;

public class Program 
{
    public static void Main(string[] args)
    {
        /* Crie um programa que utilize uma matriz de inicialização para armazenar
        as notas de cinco alunos em quatro disciplinas. Em seguida, calcule a média
        de cada aluno e exiba as médias na tela, uma por linha. */

        // Declaração e inicialização da matriz de notas com 5 alunos e 4 disciplinas
        int [,] notas = new int [5,4];

        // receber as notas dos alunos e armazená-las na matriz
        for(int i=0;i<5;i++)
        {
            for (int j=0;j<4;j++)
            {
                Console.WriteLine("Digite a nota do aluno " + (i+1) + " na disciplina " + (j+1));
                notas[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }

        //   média de cada aluno e exibi-la na tela
        for (int i=0;i<5;i++)
        {
            int soma=0;
            for (int j=0;j<4;j++)
            {
                soma=soma+notas[i,j];
            }     
            int media=0;
            media=soma/4;
            Console.WriteLine("A média do aluno " + (i+1) + " é: " + media);
        }
    }
}
