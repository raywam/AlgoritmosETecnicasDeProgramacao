using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioN4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos brancos, 
            //nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total de eleitores.

            int numTotalEleitores, votosBrancos, votosNulos, votosValidos;

            Console.WriteLine("Qual o número total de eleitores?");
            numTotalEleitores = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de votos brancos?");
            votosBrancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de votos nulos?");
            votosNulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de votos válidos?");
            votosValidos = int.Parse(Console.ReadLine());

            double percetBrancos, percetNulos, percetValidos;

            percetBrancos = (votosBrancos / (numTotalEleitores * 1.0)) * 100;
            percetNulos = (votosNulos / (numTotalEleitores * 1.0)) * 100;
            percetValidos = (votosValidos / (numTotalEleitores * 1.0)) * 100;

            Console.WriteLine("Resultados: {0}% Brancos, {1}% Nulos, {2}% Válidos.", percetBrancos, percetNulos, percetValidos);

            Console.ReadKey();

        }
    }
}
