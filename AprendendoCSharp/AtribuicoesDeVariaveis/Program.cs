using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de Variáveis");

        int idade = 30;
        int idadeAna = idade;
        
        Console.WriteLine(idadeAna);

        idade = 25; //Este valor não será conciderado, pois a máquina não volta atrás. A execução é linear!

        Console.WriteLine("Tecle ENTER para continuar...");
        Console.ReadLine();
    }
}