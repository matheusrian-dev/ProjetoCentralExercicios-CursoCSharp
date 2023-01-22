using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            // Acessar variável 'a' dentro do método Executar! Codifique apenas
            // dentro do método Executar
            DesafioAtributo desafio = new DesafioAtributo();
            var valor = desafio.a;
            Console.WriteLine(valor);
        }
    }
}
