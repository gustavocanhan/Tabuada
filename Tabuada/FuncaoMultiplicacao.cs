using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class FuncaoMultiplicacao
    {
        public void Multiplicar(int i, int entrada)
        {
            for (i = 0; i <= 10; i++)
            {
                int resultado = entrada * i;
                Console.WriteLine($"{entrada} x {i} = {resultado}");
            }
        }
    }
}
