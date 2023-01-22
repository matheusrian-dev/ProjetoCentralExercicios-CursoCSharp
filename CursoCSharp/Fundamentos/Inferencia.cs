using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo"; //variaveis implicitas devem ser iniciadas assim que declaradas! 
            // Exemplo incorreto: var idade; 
            Console.WriteLine(nome);
        }
    }
}
