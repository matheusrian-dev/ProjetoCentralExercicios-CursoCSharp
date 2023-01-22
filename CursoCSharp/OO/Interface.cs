using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface Teste
    {
        bool Bla(string a);
    }

    interface OperacaoBinaria
    {
        int Operacao(int a, int b); // Métodos de interface são obrigatoriamente públicos e abstratos, não podendo ser
    }                               //implementados na própria interface ou serem definidos como protected ou private

    class Soma : OperacaoBinaria, Teste
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }

        public bool Bla(string teste) //O nome da variável dentro do método herdado não precisa ser o mesmo do método abstrato.
        {
            return true;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Divisao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a / b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
            new Divisao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }

    internal class Interface
    {
        public static void Executar()
        {

        }
    }
}
