using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVETOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //DESENVOLVIDO POR RAYWAM SHINKODA
            //ATIVIDADE DE ATP PUC MINAS
            //CONTATO: raywam@hotmail.com

            //ATIVIDADE - VETORES
            //Exercício 1:  Em Belo Horizonte, sabe-se que, na primeira semana de maio, não ocorreu temperatura inferior a 15°C, nem superior a 40°C. Faça um programa que utilize de um bloco para armazenar as temperaturas de cada dia dessa semana em um vetor (de 7 posições), calcule e imprima:
            //          a)	A menor e a maior temperatura ocorrida
            //          b)	A temperatura média
            //          c)	O número de dias nos quais a temperatura foi inferior a temperatura média.
                       

            int[] N = new int[7];
            int maiorTemp, menorTemp, soma, abaixodamedia, dia;
            double media;
            string diaSemana;

            maiorTemp = menorTemp = soma = abaixodamedia = 0;
            dia = 1;

            Console.WriteLine("\n\t***** Programa para ler temperaturas da semana *****\n\n");

            for (int i = 0; i < N.Length; i++, dia++)
            {
                switch (dia)
                {
                    case 1:
                        diaSemana = "segunda-feira";
                        break;
                    case 2:
                        diaSemana = "terça-feira";
                        break;
                    case 3:
                        diaSemana = "quarta-feira";
                        break;
                    case 4:
                        diaSemana = "quinta-feira";
                        break;
                    case 5:
                        diaSemana = "sexta-feira";
                        break;
                    case 6:
                        diaSemana = "sábado";
                        break;
                    case 7:
                        diaSemana = "domingo";
                        break;
                    default:
                        diaSemana = "NaN";
                        break;
                }

                if (i == 0)
                {
                    Console.Write("Digite a temperatura de {0}: ", diaSemana);
                    N[i] = int.Parse(Console.ReadLine());

                    while (N[i] < 15 || N[i] > 40)
                    {
                        Console.Write("\aA temparatura deve ser de 15 a 40ºC. \nDigite a temperatura de {0}: ", diaSemana);
                        N[i] = int.Parse(Console.ReadLine());
                    }

                    maiorTemp = menorTemp = N[i];
                }
                else
                {
                    Console.Write("Digite a temperatura de {0}: ", diaSemana);
                    N[i] = int.Parse(Console.ReadLine());

                    while (N[i] < 15 || N[i] > 40)
                    {
                        Console.Write("\aA temparatura deve ser de 15 a 40ºC. \nDigite a temperatura de {0}: ", diaSemana);
                        N[i] = int.Parse(Console.ReadLine());
                    }

                    if (N[i] >= maiorTemp)
                        maiorTemp = N[i];
                    else
                        if (N[i] <= menorTemp)
                        menorTemp = N[i];
                }
                soma = soma + N[i];
            }

            media = soma / 7.0;

            Console.Write("\n\n{");
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write(N[i] + ",");
                if (N[i] < media)
                    abaixodamedia++;
            }
            Console.Write("}\n\n");


            Console.WriteLine("A média das temperaturas é {0}. \n\nA maior temperatura é {1} e a menor é {2}. \n\nNúmero de dias com temperatura abaixo da média: {3}", media, maiorTemp, menorTemp, abaixodamedia);

            Console.ReadKey();

        }
    }
}
