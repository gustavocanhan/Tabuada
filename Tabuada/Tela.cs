using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Tela
    {
        public void MostrarMenu()
        {
            Console.WriteLine("\n=== Tabuada de Multiplicação ===");
            Console.Write("Digite um valor inteiro ou (0 para sair): ");
        }

        public void ErroNumeroNegativo()
        {
            Console.WriteLine("Por favor, digite um número positivo.");
        }

        public void ErroValorInvalido()
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }

        public void MostrarRepetirProcesso()
        {
            Console.WriteLine("\nDeseja repetir processo?");
            Console.Write("Digite 1 para SIM ou 0 para NÃO: ");
        }

        public void MostrarMensagemSaida()
        {
            Console.WriteLine("\nEncerrando o programa. Até mais!");
        }
    }
}
