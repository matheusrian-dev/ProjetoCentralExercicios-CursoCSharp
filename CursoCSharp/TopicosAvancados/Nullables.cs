using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables
    {
        //static int num3; //variaveis que estão no nivel da classe, são inicializadas com o valor padrão
        public static void Executar()
        {
            Nullable<int> num1 = null; //primeira forma de gerar uma variavel que aceita valor nulo
            int? num2 = null; //segunda forma de gerar uma variavel que aceita valor nulo
            //não é possivel utilizar variaveis que não foram atribuidas
            //int num 3;
            //Console.WriteLine(num3);
            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num:{0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor.");
            }
            //int valor = num1; //não é possivel atribuir um valor nulo a um valor não nullable
            int valor = num1 ?? 1000; //Caso seja necessário, é possivel inserir um valor padrão através do ?? para que esse valor substitua o nulo
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault(); //outra forma de se converter um valor nullable, retornando o valor padrão do tipo
            Console.WriteLine(resultado);

            try
            {
                //utilizar somente o .Value irá causar uma exceção caso não haja valor na variável para que seja feita a operação
                //int x = num1.Value;
                //int y = num2.Value;
                //para uma segurança maior utilize o .GetValueOrDefault
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
