namespace GeradorDiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Gerador de Diamante com X");
            Console.WriteLine("=========================");

            int numero = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("\nDigite um número ímpar: ");
                
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero % 2 != 0)
                    {
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida! O número deve ser ímpar. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite um número inteiro.");
                }
            }

            int espacos = tamanho / 2;
            int xs = 1;

            for (int i = 0; i <= tamanho / 2; i++)
            {
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < xs; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
                espacos--;
                xs += 2;
            }

            espacos = 1;
            xs = tamanho - 2;

            for (int i = 0; i < tamanho / 2; i++)
            {
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < xs; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
                espacos++;
                xs -= 2;
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

    }
}
