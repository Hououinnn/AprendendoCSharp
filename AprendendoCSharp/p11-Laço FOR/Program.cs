using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 10 - Laços de repetição");

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes += 1)
        {
            investimento = investimento * 5/100;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine(); 
    }
}