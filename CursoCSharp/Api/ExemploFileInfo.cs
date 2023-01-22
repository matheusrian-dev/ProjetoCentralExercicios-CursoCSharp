using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);
                //verifica se o arquivo existe e, caso exista, o exclui
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = new StreamWriter(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original!"); //gera o arquivo
            }

            FileInfo origem = new FileInfo(caminhoOrigem); //grava os dados do arquivo dentro da variavel fileinfo
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia); //copia os dados da variavel em um novo arquivo
            origem.MoveTo(caminhoDestino); //move o arquivo para um caminho desejado

        }
    }
}
