using System;

namespace GeradorDiamanteX.ConsoleApp
{
    public class GeradorDiamante
    {
        public static void DesenharDiamante(int tamanho)
        {
            // Desenha a parte de cima do diamante e a linha do meio
            DesenharParteDiamante(tamanho, true);

            // Desenha a parte de baixo do diamante
            DesenharParteDiamante(tamanho, false);
        }

        private static void DesenharParteDiamante(int tamanho, bool parteSuperior)
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

        private static void DesenharLinha(int espacos, int xs)
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
    }
} 