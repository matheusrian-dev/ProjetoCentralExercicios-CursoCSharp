using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue; //O continue faz com que pule o resto da interação atual e vá para a próxima. Ex: sai da
                              //primeira repetição e vai para a segunda sem chegar ao Console.Write
                }

                Console.Write(i + " ");
            }
        }
    }
}
