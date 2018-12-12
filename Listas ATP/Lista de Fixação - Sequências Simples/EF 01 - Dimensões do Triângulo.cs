using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioN2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a área do retângulo. 

            int baseTri, altTri;

            Console.WriteLine("Digite a base do triagulo:");
            baseTri = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do triangulo:");
            altTri = int.Parse(Console.ReadLine());

            int area;

            area = baseTri * altTri;

            Console.WriteLine("A área do trigulo é {0}", area);

            Console.ReadKey();

        }
    }
}
