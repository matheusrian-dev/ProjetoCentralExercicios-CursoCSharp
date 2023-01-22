using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Utilizando a formatação F1, ele reduzirá a quantidade de casas decimais para 1 arredondando o número
            Console.WriteLine(valor.ToString("C")); // Utilizando a formatação C, ele dará a formatação monetária padrão do seu sistema operacional.
            Console.WriteLine(valor.ToString("P")); // Utilizando a formatação P, ele dará o valor percentual (multiplica por 100 e adiciona o simbolo %)
            Console.WriteLine(valor.ToString("#.##")); // Método alternativo para formatar o número e suas casas decimais com
                                                       // base na formatação mostrada(realizando o arredondamento no caso de redução decasas decimais)
            CultureInfo cultura = new CultureInfo("pt-BR"); // Método para utilizar uma cultura específica 
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Utilizando a Formatação D+quantidadeDesejada, será acrescentado 0's a esquerda do valor até completar
                                                        // a quantidade desejada de números
        }
    }
}
