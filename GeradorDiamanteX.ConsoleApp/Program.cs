namespace GeradorDiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutarPrograma();
        }

        static void ExecutarPrograma()
        {
            bool continuarPrograma = true;

            while (continuarPrograma)
            {
                ExibirCabecalho();
                int tamanhoDiamante = ObterNumeroImpar();
                
                Console.Clear();
                Console.WriteLine($"Diamante de tamanho {tamanhoDiamante}:\n");
                
                DesenharDiamante(tamanhoDiamante);
                
                continuarPrograma = DesejaContinuar();
            }

            FinalizarPrograma();
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("Gerador de Diamante com X");
            Console.WriteLine("=========================");
        }

        static int ObterNumeroImpar()
        {
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

            return numero;
        }

        static void DesenharDiamante(int tamanho)
        {
            // Desenha a parte de cima do diamante e a linha do meio
            DesenharParteDiamante(tamanho, true);

            // Desenha a parte de baixo do diamante
            DesenharParteDiamante(tamanho, false);
        }

        static void DesenharParteDiamante(int tamanho, bool parteSuperior)
        {
            int linhas = parteSuperior ? tamanho / 2 + 1 : tamanho / 2;
            
            for (int i = 0; i < linhas; i++)
            {
                int indice = parteSuperior ? i : i + 1;
                int espacos = parteSuperior ? tamanho / 2 - i : indice;
                int xs = parteSuperior ? 2 * i + 1 : tamanho - 2 * indice;
                
                DesenharLinha(espacos, xs);
            }
        }

        static void DesenharLinha(int espacos, int xs)
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
        }

        static bool DesejaContinuar()
        {
            Console.WriteLine("\nDeseja gerar outro diamante? (S/N): ");
            string resposta = Console.ReadLine().Trim().ToUpper();
            
            return resposta == "S";
        }

        static void FinalizarPrograma()
        {
            Console.Clear();
            Console.WriteLine("Programa finalizado. Obrigado por utilizar o Gerador de Diamante!");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
