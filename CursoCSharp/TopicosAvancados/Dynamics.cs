using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste"; //objetos dinamicos são fracamente tipados, tendo seu tipo determinado no momento da execução, podendo ser alterado com facilidade
            meuObjeto = 3; //porém é necessário cautela ao utilizar o mesmo, pois ele impede o retorno de erros no compilador
            meuObjeto++; //sendo necessário uma forma de de verificação externa
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject(); //Permite que adicione e exclua membros de suas instancias em tempos de execução e também defina e obtenha
            aluno.nome = "Maria Julia"; //valores desses membros. Dá suporte a associação dinâmica, permitindo o uso de uma sintaxe padrão como a utilizada ao lado.
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.Idade}");
        }
    }
}
