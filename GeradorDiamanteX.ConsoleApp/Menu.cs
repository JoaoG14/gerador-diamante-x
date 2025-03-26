using System;

namespace GeradorDiamanteX.ConsoleApp
{
    public class Menu
    {
        public static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("Gerador de Diamante com X");
            Console.WriteLine("=========================");
        }

        public static int ObterNumeroImpar()
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

        public static bool DesejaContinuar()
        {
            Console.WriteLine("\nDeseja gerar outro diamante? (S/N): ");
            string resposta = Console.ReadLine().Trim().ToUpper();
            
            return resposta == "S";
        }

        public static void FinalizarPrograma()
        {
            Console.Clear();
            Console.WriteLine("Programa finalizado. Obrigado por utilizar o Gerador de Diamante!");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
} 