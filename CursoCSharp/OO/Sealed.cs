using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    internal class Sealed
    {
        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 1_407_033.65;
            }
        }
        
        //public SouFilho : SemFilho() //Não é possível herdar de classe sealed
        //{

        //}

        class Avo
        {
            public virtual bool HonrarNomeFamilia()
            {
                return true;
            }
        }
        class Pai : Avo
        {
            public override sealed bool HonrarNomeFamilia()
            {
                return true;
            }
        }

        class FilhoRebelde : Pai
        {
            //public override bool HonrarNomeFamilia()
            //{
            //    return false; //Quando um método é selado, não é possível alterar seu valor em classes filhas através do override.
            //}

            public new bool HonrarNomeFamilia()
            {
                return false; //Uma solução seria criar um novo através do new, ocultando o método selado que foi herdado.
            }
        }

        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
