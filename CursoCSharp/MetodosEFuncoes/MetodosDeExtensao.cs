using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        //O método de extensão permite adicionar uma função dentro do tipo de variável específicado na função de extensão
        public static int Soma(this int num, int outroNum) //O this é a instância do valor com que está trabalhando naquele momento
        {
            return num + outroNum;
        }

        public static int Subtracao(this int num, int outroNum)
        {
            return num - outroNum;
        }

    }
    internal class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5; //nesse exemplo o this reconhece o 5 como o this int num

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(10));

            Console.WriteLine(2.Soma(3));      //É possível chamar o método através de qualquer valor(inclusive os literais como demonstrado à esquerda)
            Console.WriteLine(2.Subtracao(4)); //que tenha o mesmo tipo da extensão
        }
    }
}
