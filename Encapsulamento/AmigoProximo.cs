using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); //Não tem acesso por não ser transmitido por herança (protected)
            Console.WriteLine(amiga.NumeroCelular); //interno (internal) dentro do próprio projeto, logo tem acesso
            Console.WriteLine(amiga.JeitoDeFalar); //embora seja protected, por contar com o internal, classes compostas também tem acesso
            //Console.WriteLine(amiga.SegredoFamilia);//também não tem acesso por ser private e protected, sendo acessado somente pela mesma ou por herança
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);//também não tem acesso por ser private, sendo acessado somente pela própria classe.
        }
    }
}
