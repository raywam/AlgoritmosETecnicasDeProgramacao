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
            //DESENVOLVIDO POR RAYWAM SHINKODA
            //PROGRAMA QUE GERA O DIA SEGUINTE
            //CONTATO: raywam@hotmail.com

            //Faça um programa que leia uma data qualquer (dia, mês e ano) e calcule a data do próximo dia. Lembre-se que em anos bissextos o mês de fevereiro tem 29 dias. 
            //(Dica: Considere um ano bissexto quando for divisível por 4)

            char repete;

            do
            {
                int dia, mes, ano;

                Console.WriteLine("\n\n\t***Programa para Calcular e Gerar o Dia Seguinte***");
                Console.Write("\nPor favor, insira o dia:");
                dia = int.Parse(Console.ReadLine());
                Console.Write("\nLogo, insira o mês:");
                mes = int.Parse(Console.ReadLine());
                Console.Write("\nPor fim, insira o ano:");
                ano = int.Parse(Console.ReadLine());
                while (dia > 31 || (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || mes > 12 || (ano % 4 != 0 && dia > 28 && mes == 2) || (ano % 4 == 0 && dia > 29 && mes == 2))
                {
                    Console.Write("\n" + dia + "/" + mes + "/" + ano + " não é uma data válida. Tente novamente.");
                    Console.Write("\n\nPor favor, insira o dia:");
                    dia = int.Parse(Console.ReadLine());
                    Console.Write("\nLogo, insira o mês:");
                    mes = int.Parse(Console.ReadLine());
                }

                if (ano % 4 == 0) //O ANO É BISSEXTO
                {
                    if (mes == 2)
                    {
                        if (dia < 29)
                        {
                            dia++;
                        }
                        else
                        {
                            if (dia == 29)
                            {
                                dia = 1;
                                mes++;
                            }
                        }
                    }
                    else
                    {

                        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                        {
                            if (dia < 31)
                            {
                                dia++;
                            }
                            else
                            {
                                if (dia == 31)
                                {
                                    dia = 1;
                                    if (mes == 12)
                                    {
                                        mes = 1;
                                        ano++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                            {
                                if (dia < 30)
                                {
                                    dia++;
                                }
                                else
                                {
                                    if (dia == 30)
                                    {
                                        dia = 1;
                                        mes++;
                                    }
                                }
                            }
                        }
                    }
                }
                else //O ANO NÃO É BISSEXTO
                {
                    if (mes == 2)
                    {
                        if (dia < 28)
                        {
                            dia++;
                        }
                        else
                        {
                            if (dia == 28)
                            {
                                dia = 1;
                                mes++;
                            }
                        }
                    }
                    else
                    {
                        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                        {
                            if (dia < 31)
                            {
                                dia++;
                            }
                            else
                            {
                                if (dia == 31)
                                {
                                    dia = 1;
                                    if (mes == 12)
                                    {
                                        mes = 1;
                                        ano++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                            {
                                if (dia < 30)
                                {
                                    dia++;
                                }
                                else
                                {
                                    if (dia == 30)
                                    {
                                        dia = 1;
                                        mes++;
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("O dia seguinte é: " + dia + "/" + mes + "/" + ano);
                break;
            }
            while (repete == 'S' || repete == 's');

            Console.WriteLine("\n\nObrigado. Tecle algo para sair.");
            Console.ReadLine();
        }
    }
}
