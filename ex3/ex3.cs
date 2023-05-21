using System;

public class Program 
{
    public static void Main(string[] args)
    {
        
        string[] países = new string[5];

        países[0] = "Brasil";
        países[1] = "Argentina";
        países[2] = "Chile";
        países[3] = "Uruguai";
        países[4] = "Paraguai";

        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(países[i]);
        }
    }
}
