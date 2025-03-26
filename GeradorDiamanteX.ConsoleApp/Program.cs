using System;

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
                Menu.ExibirCabecalho();
                int tamanhoDiamante = Menu.ObterNumeroImpar();
                
                Console.Clear();
                Console.WriteLine($"Diamante de tamanho {tamanhoDiamante}:\n");
                
                GeradorDiamante.DesenharDiamante(tamanhoDiamante);
                
                continuarPrograma = Menu.DesejaContinuar();
            }

            Menu.FinalizarPrograma();
        }
    }
}
