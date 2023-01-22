using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    internal class PrimeiraExcecao
    {
        public class Conta
        {
            double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo Insuficiente.");
                }

                Saldo -= valor;
            }
        }
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try //Quando se utiliza um método que pode causar um erro, é recomendado a utilização do try catch para o tratamento de exceção.
            {
                //int.Parse("adc");

                conta.Sacar(1600);
                Console.WriteLine("Saque realizado com sucesso!");
            } catch (Exception ex) //é possível utilizar o tipo de exception mais genérico, mas também pode-se utilizar diretamente o específico utilizado no tratamento da exceção.
            {
                Console.WriteLine(ex.GetType().Name); //A função GetType().Name retorna o nome correto da classe, identificando o tipo de exception que foi retornada no try.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!"); //O finally é executado mesmo que haja exceções dentro do try.
            }
        }
    }
}
