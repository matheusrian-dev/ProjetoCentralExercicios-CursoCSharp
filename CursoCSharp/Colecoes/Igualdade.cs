using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // o resultado dará falso, pois as variáveis
                                         // apontam para locais diferentes de memória
            Console.WriteLine(p2 == p3); // nesse caso retornará true, pois apontam pro mesmo endereço de memória

            Console.WriteLine(p1.Equals(p2)); // esse método continuará resultando falso pois o .Equals compara
                                              // justamente o endereço de memória, caso não seja feito o override
                                              // utilizado na classe ColecoesList 
        }
    }
}
