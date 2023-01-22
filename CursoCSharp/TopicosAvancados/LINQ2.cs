using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
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
            //retorna o primeiro valor encontrado que seja igual ao parametro passado
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro")); //porém caso não seja encontrado um valor que atenda aos requisitos, será retornado um erro;
            Console.WriteLine($"{pedro.Nome} - Nota: {pedro.Nota}");

            //método para contornar o problema do código acima
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano")); //caso não seja encontrado será retornado o valor padrão (nulo)
            if(fulano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana")); //First retorna o primeiro valor encontrado que seja igual ao paramero passado
            Console.WriteLine($"{ana.Nome} - Nota: {ana.Nota}"); //contem o mesmo problema do Single, caso não seja encontrado um valor que atenda, retornará um erro

            //método para contornar o problema acima
            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }

            //o Last funciona da mesma forma que os anteriores, logo irei adicionar somente o LastOrDefault no exemplo
            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"{outraAna.Nome} - Nota: {outraAna.Nota}");

            //Skip pula os valores conforme o parametro passado
            var exemploSkip = alunos.Skip(1).Take(3); //já o Take retira os valores conforme o parametro passado (3 valores) e gera a nova variavel
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            //retorna o maior valor do atributo passado
            var maiorNota = alunos.Max(alunos => alunos.Nota);
            Console.WriteLine(maiorNota);
            
            //retorna o menor valor do atributo passado
            var menorNota = alunos.Min(alunos => alunos.Nota);
            Console.WriteLine(menorNota);

            //soma dos valores do atributo passado
            var somaNota = alunos.Sum(alunos => alunos.Nota);
            Console.WriteLine(somaNota);

            //media dos valores do atributo passado
            var mediaDasNotas = alunos.Average(alunos => alunos.Nota);
            Console.WriteLine(mediaDasNotas);

            //media dos alunos aprovados
            var mediaDosAlunosAprovados = alunos.Where(a => a.Nota >= 7).Average(alunos => alunos.Nota);
            Console.WriteLine(mediaDosAlunosAprovados);
        }
    }
}
