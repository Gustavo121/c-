﻿using System;
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
            Console.ReadLine();
        }
    }
}
