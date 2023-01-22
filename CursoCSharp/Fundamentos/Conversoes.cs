using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro; // conversão implícita de inteiro para double
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; // para converter explicitamente um tipo para outro utilizamos o método ao lado chamado casting
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); // Método alternativo para conversão de valores
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("Digite um número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // Método mais seguro para tentar converter um valor recebido 
            Console.WriteLine("Resultado 1: {0}", numero); // Caso não consiga realizar o Parse, ele retornará o valor padrão, nesse caso o 0
            
            Console.WriteLine("Digite um segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); // Método anterior feito de forma mais enxuta, otimizando o mesmo
            Console.WriteLine("Resultado 2: {0}", numero2); 

        }
    }
}
