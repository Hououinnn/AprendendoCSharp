using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio dos míltiplos de 3!");

        for (int numero = 1; numero <= 100; numero++)
        {
            if(numero % 3 == 0)
            {
                Console.WriteLine("Os números múltiplos de 3 entre 1 e 100 são: " + numero );
            }
        }

        Console.WriteLine("Tecle ENTER para continuar...");
        Console.ReadLine();
    }
}