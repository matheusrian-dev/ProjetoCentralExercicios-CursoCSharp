using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Data sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            
            //Data com horas
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine("Hora: " + agora.Hour);
            Console.WriteLine("Minutos: " + agora.Minute);

            var amanha = agora.AddDays(1); //adicionar um dia
            Console.WriteLine(amanha);

            var ontem = agora.AddDays(-1); //remover um dia
            Console.WriteLine(ontem);

            Console.WriteLine(agora.ToString("dd")); //somente o dia
            Console.WriteLine(agora.ToString("d")); //data completa
            Console.WriteLine(agora.ToString("D")); //data completa em formato de texto formal
            Console.WriteLine(agora.ToString("g")); //data completa com horas
            Console.WriteLine(agora.ToString("G")); //data completa com horas e segundos
            Console.WriteLine(agora.ToString("dd-MM-yyyy HH:mm")); //data com formato personalizado

        }
    }
}
