using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;
            Console.WriteLine(-valorNegativo); // Operador unário "-" inverte o sinal de um determinado operando
            Console.WriteLine(!booleano); // Operador unário "!" inverte o valor de um operando booleano ou expressão
                                          // tornando true em false e vice e versa
            numero1++;
            Console.WriteLine(numero1);    // Diferença de se utilizar o operador de incrementação/decrementação antes ou depois da variável:
                                           // Utilizando o operador antes da variável passa ao sistema a necessidade de que seja 
                                           // realizada a operação com prioridade, sendo realizada antes de outras operações no mesmo comando

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // exemplo de como funciona a prioridade do operador antes da variável, porém é um código muito confuso, evite!
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
