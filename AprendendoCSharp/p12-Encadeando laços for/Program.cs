using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Encadeando laços for");

        double fatorRendimento = 5 / 100;
        double valorInvestimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                valorInvestimento *= fatorRendimento; 
            }

            fatorRendimento += (1 / 1000);
        }

        Console.WriteLine("Depois de 5 anos você terá " + valorInvestimento);

        Console.WriteLine("Tecle ENTER para continuar...");
        Console.ReadLine();
    }
}