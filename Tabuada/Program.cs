using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tela tela = new Tela();
            FuncaoMultiplicacao funcao = new FuncaoMultiplicacao();
            RepetirCodigo repetir = new RepetirCodigo();

            while (true)
            {
                tela.MostrarMenu();

                if (int.TryParse(Console.ReadLine(), out int entrada))
                {
                    if(entrada == 0)
                    {
                        break;
                    }

                    if (entrada < 0)
                    {
                        tela.ErroNumeroNegativo();
                        continue;
                    }
                                        
                    funcao.Multiplicar(0, entrada);
                }
                else
                {
                    tela.ErroValorInvalido();
                    continue;
                }

                if (!repetir.RepetirProcesso())
                {
                    break;
                }
            }
            
            tela.MostrarMensagemSaida();
        }
    }
}
