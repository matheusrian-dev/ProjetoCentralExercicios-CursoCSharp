using System;
using System.IO;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{

    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            //Para se utilizar o using, é necessário que o tipo de dado implemente a interface IDisposable.

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path + ".txt"))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
