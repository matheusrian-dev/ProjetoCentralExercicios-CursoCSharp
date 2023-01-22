using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X"); //Em casos que há somente uma sentença de código na função,
                                                                             //não é necessário montar o bloco com {} e return.
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano); //O último tipo de variavel passada define o tipo de retorno.
            Console.WriteLine(formatarData(1, 1, 2019));                                                                        //Caso haja somente um tipo na definição, o sistema interpreta
                                                                                                                                //que não há parâmetros na função.
        }
    }
}
