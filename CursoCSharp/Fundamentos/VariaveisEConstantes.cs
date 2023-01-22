using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415; constantes não podem ser alteradas

            double area = PI * raio * raio;
            Console.WriteLine("Área é :" + (area + 1000)); // Quando o writeline começa com string, mesmo que
                                                           // haja 2 números separados por um sinal de + em seguida
                                                           // não será realizada a soma deles, mas sim a concatenação
                                                           // Ex: ("A " + 10 + 10) resultado: "A 1010"
                                                           // A solução para isso seria acrescentar parenteses entre os números que deseja somar

            // Tipos Internos
            bool estaChovendo = true; //booleano para falso e verdadeiro
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45; // byte para valores numéricos inteiros de 8-bit(1 byte) sem sinal de 0 a 255.
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // sbyte para valores numéricos inteiros 8-bit(1 byte) na faixa -128 até 127
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue; // short para valores inteiros de 16-bits(2 bytes) de -32768 até 32767.
            Console.WriteLine("Salário é " + salario);

            int menorValorInt = int.MinValue; // int para valores inteiros de 32-bits(4 bytes) de -2.147.483.648 a 2.147.483.647
            Console.WriteLine("Menor Valor Inteiro é " + menorValorInt); // É o mais utilizado entre os inteiros!

            uint populacaoBrasileira = 207_600_000; // uint é o valor inteiro de 32-bits(4 bytes) sem sinal (sempre positivo) de 0 a 4.294.967.295
            Console.WriteLine("População Brasileira " + populacaoBrasileira); // O underscore pode ser utilizado como separador numérico para
                                                                              // deixar o número mais fácil de ler! (não altera o valor)
            long menorValorLong = long.MinValue; // long para valores inteiros de 64-bits(8 bytes) de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            Console.WriteLine("Menor Valor Long é " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // ulong para valor inteiro de 64-bits(8 bytes) sem sinal (sempre positivo) de 0 a 18.446.744.073.709.551.615
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f; // float para valores reais com ponto flutuante de 4 bytes
            Console.WriteLine("Preço do Computador " + precoComputador); //IMPORTANTE! Por padrão qualquer número com casa decimal é lido pelo sistema como double,
                                                                         //para ele ser reconhecido como float, insira o f no final do mesmo. Ex: 9.99f
            double valorDeMercadoDaApple = 1_000_000_000_000.00; // double para valores reais com ponto flutuante de 8 bytes. Mais utilizado entre os números reais!
            Console.WriteLine("Valor de Mercado da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // decimal para valores reais com ponto flutuante de 16 bytes
            Console.WriteLine("Distância entre as Estrelas: " + distanciaEntreEstrelas);

            char letra = 'b'; // char representa um único caractere UTF-16 Unicode entre aspas simples. 
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo!"; // string representa uma cadeia de caracteres entre aspas duplas.
            Console.WriteLine(texto);

        }
    }
}
