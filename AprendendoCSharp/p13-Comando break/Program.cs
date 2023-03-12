using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Comando break");
      
        for (int contaLinhas = 0; contaLinhas < 10; contaLinhas++)
        {
            for (int contaColuna = 0; contaColuna < 10; contaColuna++)
            {
                Console.Write("*");
                if (contaColuna >= contaLinhas)
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Tecle ENTER para continuar...");
        Console.ReadLine();
    }
}