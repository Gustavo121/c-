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

            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 213123123;

            Console.WriteLine(cor_favorita);

            cor_favorita = 321123.233f;

            Console.WriteLine(cor_favorita);

            Console.ReadLine();

        }
    }
}
