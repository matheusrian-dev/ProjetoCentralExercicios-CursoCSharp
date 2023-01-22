using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X, Y;
    }
    public class CPonto
    {
        public int X, Y;
    }

    internal class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição feita por valor pois se trata de um struct!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}",  copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 }; 
            CPonto copiaPonto2 = ponto2; // Atribuição feita por referência pois se trata de uma classe!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}
