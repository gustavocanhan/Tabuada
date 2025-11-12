using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class RepetirCodigo
    {
        Tela tela = new Tela();

        public bool RepetirProcesso()
        {
            tela.MostrarRepetirProcesso();

            if (int.TryParse(Console.ReadLine(), out int continuar))
            {
                if (continuar == 0)
                {
                    return false;
                }

                return true;
            }
            else
            {
                tela.ErroValorInvalido();
                return false;
            }
        }
    }
}
