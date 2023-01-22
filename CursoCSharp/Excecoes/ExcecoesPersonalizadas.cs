using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    //Nesse exemplo geraremos um número aleatório entre -30 e 30, caso seja gerado um número negativo ou um número positivo ímpar, a exceção será acionada
    public class NegativoException : Exception //Para que uma classe possa ser considerada uma exception personalizada, ela precisa herdar da exception genérica
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }

    internal class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);
            if (valor < 0)
            {
                throw new NegativoException("Número Negativo");
            }

            if (valor % 2 == 1)
            {
                throw new ImparException("Número Ímpar");
            }

            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar()); //Ao utilizar mais de uma exception, em caso de necessidade da exception genérica, lembre-se de deixá-la no último catch.
            } catch(NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception) //(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado, contate o administrador do sistema.");
                //Console.WriteLine(ex.Message.ToString()); //Caso queira a mensagem do erro traduzida para a linguagem do sistema.
            }
        }
    }
}
