using System;
class programa
{

    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true; 



        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else  
        {
            Console.WriteLine("Entrada negada!");
        }


        Console.WriteLine("Tecle ENTER para continuar...");
        Console.ReadLine(); 

    }

}