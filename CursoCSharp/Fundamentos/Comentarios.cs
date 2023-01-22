using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Comentarios
    {
        /// <summary>
        /// Comentário com o XML Comments (3 barras)
        /// é possível adicionar outras informações ou métodos utilizando o CTRL + Espaço
        /// </summary>
        public static void Executar()
        {
            // Cuidado com os comentários desnecessários
            // Mantenha o código limpo para que não seja necessário comentários demais!
            Console.WriteLine("Código claro é sempre melhor!");
            Console.WriteLine("O C# tem o XML Comments");
            /* Comentário de
             * múltiplas linhas...
             */
            Console.WriteLine("1"); // CTRL + K, CTRL + C: Comenta o código selecionado
            Console.WriteLine("2"); // CTRL + K, CTRL + U: Descomenta o código selecionado
        }
    }
}
