using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length); // Retorna o tamanho da string

            string valorImportante = null;
            //Console.WriteLine(valorImportante.Length); // Algumas notações retornam erro em variaveis com valores nulas
            Console.WriteLine(valorImportante?.Length); // Navegação segura previne esse erro informando ao sistema que a variável pode ser nula.
        }
    }
}
