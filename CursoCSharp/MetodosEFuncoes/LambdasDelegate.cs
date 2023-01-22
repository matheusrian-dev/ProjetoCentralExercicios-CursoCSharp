using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class LambdasDelegate
    {
        delegate double Operacao(double x, double y);

        public static void Executar()
        {
            //Delegate nada mais é do que definir um tipo que armazena uma assinatura de uma função.
            //Essa assinatura sendo respeitada, é possível criar uma variável do tipo desse delegate
            //e colocar uma função que respeita essa assinatura.
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));

        }
    }
}
