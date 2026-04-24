using System;
using System.Globalization;

namespace uri
{
    class Pronpt
    {
        static void Main(string[] args)
        {



            int pontos = 0;

            Console.WriteLine("=== JOGO DE VERDADEIRO OU FALSO ===");
            Console.WriteLine("Responda com V para Verdadeiro ou F para Falso");
            Console.WriteLine();

            // Pergunta 1
            Console.WriteLine("1) O Brasil fica na Europa?");
            string resposta1 = Console.ReadLine().ToUpper();

            if (resposta1 == "F")
            {
                Console.WriteLine("Correto!");
                pontos++;
            }
            else
            {
                Console.WriteLine("Errado!");
            }

            Console.WriteLine();

            // Pergunta 2
            Console.WriteLine("2) 10 é um número par?");
            string resposta2 = Console.ReadLine().ToUpper();

            if (resposta2 == "V")
            {
                Console.WriteLine("Correto!");
                pontos++;
            }
            else
            {
                Console.WriteLine("Errado!");
            }

            Console.WriteLine();

            // Pergunta 3
            Console.WriteLine("3) O Sol é um planeta?");
            string resposta3 = Console.ReadLine().ToUpper();

            if (resposta3 == "F")
            {
                Console.WriteLine("Correto!");
                pontos++;
            }
            else
            {
                Console.WriteLine("Errado!");
            }

            Console.WriteLine();
            Console.WriteLine("=== FIM DO JOGO ===");
            Console.WriteLine("Você fez " + pontos + " ponto(s) de 3.");

            Console.ReadLine();





        }
    }
}