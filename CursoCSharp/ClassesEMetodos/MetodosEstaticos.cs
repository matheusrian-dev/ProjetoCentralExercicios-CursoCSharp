using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public int Somar(int a, int b) //um método estático não pode ser acessado por
                                       //uma instância de uma classe! Da mesma forma que
                                       //um método não estático não pode ser acessado
                                       //diretamente pela classe! (sem instância)
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b) //utilizando métodos estáticos é possível utilizá-los
                                                    //sem a necessidade de instanciar a classe!
        {
            return a * b; 
        }
    }


    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,2)); 
        }
    }
}
