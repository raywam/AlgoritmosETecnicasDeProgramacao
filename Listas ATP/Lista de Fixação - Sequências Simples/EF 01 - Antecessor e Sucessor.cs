using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioN1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor e o seu sucessor. 

            int valor;

            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Antecessor = {0}. Sucessor = {1}", valor - 1, valor + 1);

            Console.ReadKey();
        }
    }
}
