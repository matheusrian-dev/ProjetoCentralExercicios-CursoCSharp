using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //Necessário para utilizar os métodos referentes ao CultureInfo

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Caso não queira utilizar a cultura utilizada pelo seu sistema
                                                                                             // utilize o CultureInfo.InvariantCulture como mostrado ao lado             
            Console.WriteLine($"{nome} {idade} R$ {salario}");
        }
    }
}
