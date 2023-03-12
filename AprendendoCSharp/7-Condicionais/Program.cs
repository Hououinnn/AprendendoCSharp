
using System;
class programa
{

    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18) //É o mesmo que um "se". É uma possibilidade que pode ou não ser realizda. No caos, executada.
        {
            Console.WriteLine("Pode entrar!");
        }

        else //Alternativa ao if. É executada caso a condição do if não seja cumprida. Não recebe parâmetros. 
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("Ele está acompanhado, então pode entrar!");
            }
            else
            {
                Console.WriteLine("Entrada negada!");
            }
        }


        Console.WriteLine("Tecle ENTER para continuar...");
        Console.ReadLine();

    }

}
