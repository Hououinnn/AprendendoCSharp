class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("DESAFIO FATORIAL!");

        int fatorial = 1;
        
        for (int numeroAtual = 1; numeroAtual <= 10; numeroAtual++)
        {
            fatorial = fatorial * numeroAtual;

            Console.WriteLine("O fatorial de " + numeroAtual + " é : " + fatorial);
        }

         Console.WriteLine("Tecle ENTER para continuar...");
        Console.ReadLine();
    }
}    