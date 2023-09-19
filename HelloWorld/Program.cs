using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TIPOS DE VARIAVEIS

            // Int - -156 como 32334     Números inteiros
            // Flot - 15.6 como 232.132  Números com casas decimais
            // Bool - true ou false
            // String - "Texto"
            // Char - 'a'   Apenas um caracter

            // A-Z
            // 0 - 9
            // @ $ .
            // _
            /*
             * EXEMPLOS
            int segundaGuerraMundial = 1942;
            string corFavorita = "Vermelho";
            float velocidadeF1 = 294.48f;
            bool segundaGuerraMundialAconteceu = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 348.29f;
            corFavorita = "Roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);
            */

            /*
             * VARIAVEL SEM TIPO DEFINIDO, POREM O C# SABE QUAL O TIPO
            var cor_favorita = "Vermelho";
            var modeloDoProduto = 2323;
            */

            /*
             * UTILIZANDO DYNAMIC, POSSO TER UMA VARIAVEL COM VARIOS TIPOS DIFERENTES
             
            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 213123123;

            Console.WriteLine(cor_favorita);

            cor_favorita = 321123.233f;

            Console.WriteLine(cor_favorita);
            */

            /*
             * UTILIZO CONST PARA COLOCAR UM VALOR QUE NAO VAI SER ALTERADO;
            const float PI = 3.145565656f;
            */
            /*
            string nome = "";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);
            */

            /*
            int numeroQualquer = 20 + 20 - 80;
            int numeroMult = 10 * 90;
            int numeroDiv = 5 / 2; // quando divide 2 numero inteiros, c# tras o result inteiro
            // ex: result correto é 2.5, porem ele so tras o 2 como result.

            float numeroDecimal = 5.0f / 2; // neste caso o numero com a casa decimal aparece no result.
            // ex: mudei o tipo da variavel e coloquei um numero decimal.

            int ordemSinais = 2 + 2 * 10; // ficar atendo sempre a ordem de execussão de sinais

            int ordemSinais2 = (2 + 2) * 10; // sempre executa o que tiver em () primeiro.

            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(numeroDecimal);
            Console.WriteLine(ordemSinais);
            Console.WriteLine(ordemSinais2);
            */

            /*
            if (1 >= 20) // SE
            {
                Console.WriteLine("É verdade!");
            }
            else if (20 != 20)
            {
                Console.WriteLine("Executou Elseif!");
            }
            else  // SE NÃO
            {
                Console.WriteLine("É mentira!");    
            }
            */

            /*
            int a = 10;
            int b = 20;
            int c = 2;

            if (a > b) // SE
            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou Elseif!");
            }
            else  // SE NÃO
            {
                Console.WriteLine("É mentira!");
            }
            */

            // &&(E ou AND) e ||(OU/OR)

            /* &&
                TRUE && TRUE -> TRUE
                FALSE && FALSE -> FALSE
                FALSE && FALSE -> FALSE
                TRUE && FALSE -> FALSE
            */

            /* ||
                TRUE || TRUE -> TRUE
                FALSE || TRUE -> TRUE
                TRUE || FALSE -> TRUE
                FALSE || FALSE -> FALSE
            */
            /*
            int a = 10;
            int b = 20;
            int c = 2;

            if (a < b && a > c) // SE
            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou Elseif!");
            }
            else  // SE NÃO
            {
                Console.WriteLine("É mentira!");
            }
            */
            /*
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine()); // Parse muda de string para inteiro

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente!");
            } else if (idade >= 19 && idade <= 60) 
            {
                Console.WriteLine("Você é um adulto!");
            }
            else 
            {
                Console.WriteLine("Você é um idoso!");
            }
            */

            //ExibirMsg();
            //GerarPreco(60, "Curso de Node.js");

            //GerarPreco(60);
            //GerarPreco(-21260);
            /*
            string valor = Console.ReadLine();
            Console.WriteLine(valor);
            */

            //Console.WriteLine(Math.Abs(-60));
            /*
            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(100, 200, 300);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            */
            /*
            string produto1 = "Sea of Thieves";
            string produto2 = "FIFA";
            string produto3 = "Minecraft";
            string produto4 = "Half-Life";
            string produto5 = "Portal";
            string produto6 = "CS";

            //ex. Array

            string[] produtos = new string[5] { 
                "Sea of Thieves",
                "FIFA",
                "Minecraft",
                "Half-Life",
                "Portal"
            };

            int[] valores = { 40, 50, 60, 70, 20 };

            produtos[1] = "FIFA 2023";
            Console.WriteLine(produtos[1]);
            */

            string cor = "Verde";

            //ex. Switch
            //Não consigo colocar operadores condicionais... neste caso use o if, else if
            switch (cor) {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                case "Rosa":
                    Console.WriteLine("Sua cor favorita é Rosa");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu não sei!");
                    break;
            }

            //ex. if / else if
            /*
            if(cor == "Vermelho") 
            {
                Console.WriteLine("Sua cor favorita é vermelho!");
            }
            else if(cor == "Amarelo")
            {
                Console.WriteLine("Sua cor favorita é Amarelo");
            }
            else if (cor == "Azul") 
            {
                Console.WriteLine("Sua cor favorita é Azul");
            }
            */
            Console.ReadLine();
        }

        private static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo!");
        }

        /*
        private static void GerarPreco(int preco, string nome)
        {
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine(preco);
        }
        */

        private static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco); // Assim tenho ctz que o numero é positivo utilizando Abs.
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }

        private static int Somar(int a, int b, int c) 
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }

    }
}
