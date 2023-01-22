using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api
{
    internal class ExemploTimeSpan
    {
        public static void Executar()
        {
            //a nomenclatura não é necessária seria possível colocar simplesmente (10,20,30,40)
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);
            Console.WriteLine("Minutos: " + intervalo.Minutes); //pega os minutos inseridos no timespan
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes); //converte o tempo inteiro do timespan em minutos

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);
            //a subtração de um datetime por outro gera um timespan
            var tempo = chegada - largada;
            Console.WriteLine("Duração :" + tempo);
            //Gera um novo timespan adicionando minutos ao timespan anterior
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            //Logo caso faça uma nova operação emcima da variavel intervalo, o valor original será levado em conta
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("ToString 1: " + intervalo.ToString("g")); //String retornada de forma padrão do timespan
            Console.WriteLine("ToString 2: " + intervalo.ToString("G")); //Adiciona os milisegundos na string retornada
            Console.WriteLine("ToString 3: " + intervalo.ToString("c")); //Adiciona um . como separador de dias e horas

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds); //Conversão de uma string para um timespan
        }
    }
}
