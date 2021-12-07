using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma =1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Porcentagem, Sair}
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Bem vindos a calculadora, Selecione uma opção abaixo!");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Porcentagem\n8-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mut();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Porcentagem:
                        Porc();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para votlar ao menu!");
            Console.ReadLine();
        }
        static void Mut()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seugndo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o número base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um número: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o número:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
        static void Porc()
        {
            Console.WriteLine("Porcentagem de um número: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Digite o numero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos porcento desse numero:");     
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)b/(float)100;
            float resultado2 = (float)resultado * (float)a;
            Console.WriteLine($"O resultado é: {resultado2}");
            Console.WriteLine("Aperte ENTER para voltar ao menu!");
            Console.ReadLine();
        }
    }
}
