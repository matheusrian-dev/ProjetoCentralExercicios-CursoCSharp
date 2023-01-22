using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2008)); //caso não encontre o valor, retorna nulo ou vazio
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");
            //Métodos para percorrer o Dictionary
            foreach (var chave in filmes.Keys) //Caso precise somente da chave
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) //Caso precise somente do valor
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)// Caso necessite de ambos
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes) // Caso necessite de ambos de forma mais simplificada, deixando o compilador
            {                             // Inferir os dados
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

        }
    }
}
