using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static class Constantes
        {
            public const double SI = 1000, DI = 900, NU = 800, OT = 700;
        }

        static void Main(string[] args)
        {   //PONTIFÍCIA UNIVERSIDADE CATÓLICA DE MINAS GERAIS
            //Departamento de Sistemas de Informação - Núcleo Universitário Barreiro           
            //Desenvolvido por Raywam Shinkoda, em 18/09/2018
            //Código referente ao Exercício Pontuado 1 - Condicionais

            //QUESTÃO: A PUCMinas mantém a seguintes informações para os seus alunos:
            //        *Nome de Matricula (número)
            //        *Nome do Aluno
            //        *Curso ( 1 - Sistemas de Informação 2 - Direito 3 - Nutrição 4 - Outros)
            //        *Tipo de Matricula (R- Regular B- Bolsa F- FIES)
            //        *Irmão matriculados na PUC

            //O valor da mensalidade é definido conforme o curso:
            //        *SI - R$ 1000,00
            //        *DI - RS  900,00
            //        *NU - R$  800,00
            //        *Outros R$700,00

            //Conforme o tipo de matricula, o aluno pode ter um desconto no valor da mensalidade conforme a tabela:
            //        *Regular  Integral
            //        *Bolsa    Desconto 50%
            //        *FIES     Desconto 90%

            //Além do mais, se o aluno não tiver nenhum tipo de desconto, e tiver irmãos matriculados na PUC,  o valor da mensalidade deve receber descontos progressivos da seguintes forma:
            //        *1 irmão: Desconto de 10%;
            //        *2 irmãos: Desconto de 20%;
            //        *3 ou mais irmãos: descont ode 30%;

            //Faça um algoritmo e C# que:
            //        *Declare e leia os dados do aluno
            //        *Calcule e imprima:
            //               *a matricula e o nome do aluno
            //               *o valor da mensalidade


            char repete;
            do
            {
                //Declaração de variáveis
                int curso, nDeIrmaos = 0;
                string nomeAluno, matricula;
                double valorCurso;
                char tipoMatricula, possuiIrmao;

                //Leitura de dados

                Console.Clear();
                Console.WriteLine("\n\n***PRIMEIRO EXERCÍCIO PRATICO - CONDICIONAIS***");
                Console.WriteLine("***PROGRAMA PARA DEFINIR O VALOR DA MENSALIDADE***");

                Console.Write("\nNome do Aluno: ");
                nomeAluno = Console.ReadLine();
                Console.Write("\nMatrícula:");
                matricula = Console.ReadLine();
                Console.Write("\n*** OPÇÕES DE CURSO: \n\n[1] Sistemas de Informação - RS {0},00 \n[2] Direito R$ {1},00 \n[3] Nutrição R$ {2},00 \n[4] Outros - RS {3},00", Constantes.SI, Constantes.DI, Constantes.NU, Constantes.OT);
                Console.Write("\n\nNúmero do curso:");
                curso = int.Parse(Console.ReadLine());
                Console.Write("\n*** OPÇÕES DE MATRÍCULA: \n\n[R] Regular - Valor Integral\n[B] Bolsa - Desconto de 50% \n[F] FIES - Bolsa de 90%");
                Console.Write("\n\nCódigo de matrícula:");
                tipoMatricula = char.Parse(Console.ReadLine());
                Console.Write("\nPossui irmãos matriculados na instituição? [S]im [N]ao ");
                possuiIrmao = char.Parse(Console.ReadLine());
                if (possuiIrmao == 's' || possuiIrmao == 'S')
                {
                    Console.Write(" \nQuantos?");
                    nDeIrmaos = int.Parse(Console.ReadLine());
                }


                switch (curso)
                {
                    case 1:
                        valorCurso = Constantes.SI;
                        break;
                    case 2:
                        valorCurso = Constantes.DI;
                        break;
                    case 3:
                        valorCurso = Constantes.NU;
                        break;
                    case 4:
                        valorCurso = Constantes.OT;
                        break;
                    default:
                        valorCurso = 0;
                        break;
                }

                switch (tipoMatricula)
                {
                    case 'B':
                    case 'b':
                        valorCurso = valorCurso / 2;
                        break;
                    case 'F':
                    case 'f':
                        valorCurso = valorCurso - (valorCurso * 0.9);
                        break;
                    default:
                        Console.WriteLine("\a\a\n Erro!");
                        break;
                }

                if (tipoMatricula == 'R' || tipoMatricula == 'r')
                {
                    switch (nDeIrmaos)
                    {
                        case 0:
                            valorCurso = valorCurso;
                            break;
                        case 1:
                            valorCurso = valorCurso - (valorCurso * 0.1);
                            break;
                        case 2:
                            valorCurso = valorCurso - (valorCurso * 0.2);
                            break;
                        default:
                            valorCurso = valorCurso - (valorCurso * 0.3);
                            break;
                    }
                }

                Console.Write("\n\n***********************************************\nMatricula: {0}. \nAluno: {1}. \nValor atualizado da mensalidade: {2}\n***********************************************", matricula, nomeAluno, valorCurso);

                Console.WriteLine("\n\nDeseja repetir? [S]im [N]ão");
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
