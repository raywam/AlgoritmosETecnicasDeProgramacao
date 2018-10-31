using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            char repete;

            do
            {
                int numero, chute, tentativas = 1;

                Console.WriteLine("\n\n\t***Programa Para Advinhar um Número***");
                Console.WriteLine("\n\nAdivinhe um número de 1 a 100!");


                Random rndNumero = new Random();
                numero = rndNumero.Next(1, 100);

                Console.Write("Come on! Chute: ");
                chute = int.Parse(Console.ReadLine());

                for (int love = 1; chute != numero; love++)
                {
                    if (chute < numero)
                    {
                        Console.WriteLine("\aErrou! O número advinhado é maior que " + chute + "! Came on! Tente de novo!");
                    }
                    else
                    {
                        Console.WriteLine("\aErrou! O número advinhado é menor que " + chute + "! Came on! Tente de novo!");
                    }
                    chute = int.Parse(Console.ReadLine());
                    tentativas++;
                }

                if (chute == numero)
                {
                    if (tentativas == 1)
                        Console.WriteLine("\n\nGenial! O número advinhado é exatamente " + chute + "! \n Tentativas necessárias: " + tentativas);
                    else
                        Console.WriteLine("\n\nMuito bom! O número advinhado é exatamente " + chute + "! \n Tentativas necessárias: " + tentativas);

                }

                Console.WriteLine("\n\nDeseja jogar novamente? [S]im [N]ão");
                repete = char.Parse(Console.ReadLine());
            }
            while (repete == 'S' || repete == 's');

            Console.WriteLine("\n\nObrigado. Tecle algo para sair.");
            Console.ReadLine();
            }
    }
    }
