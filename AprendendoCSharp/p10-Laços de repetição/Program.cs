using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 10 - Laços de repetição");

        double investimento = 1000;

        //rendimento de 0.5% (0.005) ao mês.

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + (investimento * 0.005);
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
            
            mes += 1;
        }

        Console.WriteLine("Tecle ENTER para fechar...");
        Console.ReadLine();
    }
}