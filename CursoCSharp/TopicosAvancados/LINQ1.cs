using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Alunos
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    internal class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Alunos>
            {
                new Alunos() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Alunos() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new Alunos() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Alunos() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Alunos() {Nome = "Tainá", Idade = 21, Nota = 7.7},
                new Alunos() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Alunos() {Nome = "Marcio", Idade = 18, Nota = 6.8},
            };

            Console.WriteLine("== Aprovados ============================");
            var aprovados = alunos.Where(a => a.Nota >= 7.0).OrderBy(a => a.Nome); //gera uma nova lista com os alunos que foram aprovados pela nota mínima, ordenado por Nome
            foreach (var aluno in aprovados)
            {
                Console.WriteLine("Aluno: " + aluno.Nome + " Nota:" + aluno.Nota);
            }

            Console.WriteLine("\n== Chamada =============================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome); //através do .Select a lista alunos é transformada em uma outra lista contendo somente o nome
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (ordenado por Idade) ======");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;
            
            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
