using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");

            double calcularMedia(double nota1, double nota2, double nota3, out String conc)
            {
                double media = (nota1 + nota2 + nota3) / 3;
                conc = media >= 7 ? "aprovado" : "reprovado";
                return media;
            }

            String conceito;
            double mediaDoAluno = calcularMedia(1.6, 9.4, 5.0, out conceito);
            Console.WriteLine("A media é " + mediaDoAluno + " e o aluno está " + conceito);
        }
    }
}
