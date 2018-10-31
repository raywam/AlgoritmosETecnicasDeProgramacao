using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Soma (int x, int y, int z)
        {
            return (x + y + z); 
        }

        static void Main(string[] args)
        {   //PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS
            //Departamento de Sistemas de Informação - Núcleo Universitário Barreiro           
            //Desenvolvido por Raywam Shinkoda, em 18/09/2018
            //Código referente a Primeira Prova Prática de Laboratório - ATP

            //QUESTÃO: Um usuário deseja um algoritmo onde possa escolher que tipo de média deseja calcular
            //a partir de 3 valores. Faça um algoritmo que leia os 3 valores inteiros e a opção escolhida pelo
            //usuário e calcule a média.

            // Opção                        Tipo de Média
            //   A                            Aritmética
            //   B                            Ponderada
            //   C                            Harmônica
            //Opção diferente de A, B, C      Mensagem de erro

            char repete;

            do
            {
                //Declaração de variáveis
                int valor1, valor2, valor3;
                float peso1, peso2, peso3;
                double media;
                char opcaoMedia;

                //Leitura de dados
                Console.Clear();
                Console.WriteLine("\n\n***PRIMEIRA PROVA PRÁTICA DE ATP***");
                Console.WriteLine("***Programa que calcula tipos de médias com valores inteiros***");
                Console.WriteLine("\nAs opções disponíveis são:");
                Console.WriteLine("\n\n[A]- Média Aritmética\n[B]- Média Ponderada\n[C]- Média Harmônica");
                Console.Write("\n\nPor favor, tecle a LETRA da opção desejada e tecle <enter>:");

                opcaoMedia = char.Parse(Console.ReadLine());

                //Instruções
                switch (opcaoMedia)
                {
                    case 'A':
                    case 'a': //MEDIA ARITMÉTICA

                        Console.Clear();
                        Console.WriteLine("\n\nÓtimo! Você escolheu a Média Aritmética.");
                        Console.Write("\n   Agora, digite o primeiro valor: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.Write("   Agora, digite o segundo valor: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.Write("   Agora, digite o terceiro valor: ");
                        valor3 = int.Parse(Console.ReadLine());

                        media = Soma(valor1, valor2, valor3) / 3.0;

                        Console.WriteLine("\n***Calculei! A média aritmética com os valores informados é: " + media);
                        break;

                    case 'B':
                    case 'b'://MEDIA PONDERADA

                        Console.Clear();
                        Console.WriteLine("\n\nÓtimo! Você escolheu a Média Ponderada.");
                        Console.Write("\n   Agora, digite o primeiro valor: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.Write("   Digite o peso para o primeiro valor: ");
                        peso1 = float.Parse(Console.ReadLine());
                        Console.Write("\n   Agora, digite o segundo valor: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.Write("   Digite o peso para o segundo valor: ");
                        peso2 = float.Parse(Console.ReadLine());
                        Console.Write("\n   Agora, digite o terceiro valor: ");
                        valor3 = int.Parse(Console.ReadLine());
                        Console.Write("   Digite o peso para o terceiro valor: ");
                        peso3 = float.Parse(Console.ReadLine());

                        media = ((valor1 * peso1) + (valor2 * valor2) + (valor3 * peso3)) / Soma(valor1, valor2, valor3);

                        Console.WriteLine("\n***Calculei! A média ponderada com os valores informados é: " + media);
                        break;

                    case 'C':
                    case 'c': //MEDIA HARMONICA

                        Console.Clear();
                        Console.WriteLine("\n\nÓtimo! Você escolheu a Média Harmônica.");
                        Console.Write("\n   Agora, digite o primeiro valor: ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.Write("   Agora, digite o segundo valor: ");
                        valor2 = int.Parse(Console.ReadLine());
                        Console.Write("   Agora, digite o terceiro valor: ");
                        valor3 = int.Parse(Console.ReadLine());

                        media = 3.0 / ((1.0 / valor1) + (1.0 / valor2) + (1.0 / valor3));

                        Console.WriteLine("\n***Calculei! A média harmônica com os valores informados é: " + media);
                        break;

                    default: //OPÇÃO DIFERENTE DE A,B,C

                        Console.WriteLine("\n\n:( \nQue pena, " + "*" + opcaoMedia + "*" + " não é uma opção válida. Reinicie o programa e tente novamente!");
                        break;

                }

                Console.WriteLine("Deseja repetir? [S]im [N]ão");
                repete = char.Parse(Console.ReadLine());
            }
            while (repete == 'S' || repete == 's');
            
            //Resultado
            Console.Clear();
            Console.WriteLine("\n\nObrigado por utilizar o programa!");
            Console.WriteLine("\nTecle algo para sair...");
            Console.ReadKey();
        }
    }
}
