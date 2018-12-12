using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioN3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade 
            //dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.

            int anos, meses, dias;

            Console.WriteLine("Anos:");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Meses:");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Dias:");
            dias = int.Parse(Console.ReadLine());

            int diasVividos;

            diasVividos = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("Ufa! Você já viveu {0} dias!!", diasVividos);

            Console.ReadKey();

        }
    }
}
