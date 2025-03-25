namespace GeradorDiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuarPrograma = true;

            while (continuarPrograma)
            {
                Console.Clear();
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

                Console.Clear();
                Console.WriteLine($"Diamante de tamanho {numero}:\n");

                int espacos = numero / 2;
                int xs = 1;

                // Parte superior do diamante (incluindo a linha do meio)
                for (int i = 0; i <= numero / 2; i++)
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

                // Parte inferior do diamante
                espacos = 1;
                xs = numero - 2;

                for (int i = 0; i < numero / 2; i++)
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

                Console.WriteLine("\nDeseja gerar outro diamante? (S/N): ");
                string resposta = Console.ReadLine().Trim().ToUpper();
                
                if (resposta != "S")
                {
                    continuarPrograma = false;
                }
            }

            Console.Clear();
            Console.WriteLine("Programa finalizado. Obrigado por utilizar o Gerador de Diamante!");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
