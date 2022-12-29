using System;
using System.Globalization;

namespace Projeto_Calculadora
{
    public class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7}

        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while(!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções: ");
                Console.WriteLine();
                Console.WriteLine("1 - Soma\n2 - Subtracao\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");
                Console.WriteLine("---------------------------------------");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz: 
                        Raiz(); 
                        break;
                }

                Console.Clear();
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            double resultado = (double)a/ b;
            Console.WriteLine($"O resultado é: {resultado.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de dois números: ");
            Console.WriteLine();
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());

            Console.WriteLine();
            double resultado = Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um número: ");
            Console.WriteLine();
            Console.Write("Digite o número: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}