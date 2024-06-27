using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu()
        }

        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());   //console.readline sempre converte o valor para string
                                                          //float.parse converte a informação para float
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("\nO resultado da soma é " + resultado);
            Console.ReadKey(); //espera o usuario digitar uma tecla para sair do console
            Menu(); //chama a função menu novamente após completar a operação


        }

        static void Subtracao()

        {

            Console.Clear();

            Console.WriteLine("Digite o Primerio valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine("\nO resultado da subtração é " + resultado);
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());


            while (v2 == 0)
            {
                Console.WriteLine("\nO segundo valor não pode ser 0");
                Console.WriteLine("Digite um novo valor:");
                v2 = float.Parse(Console.ReadLine());

            }
            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");//o $ e as chaves são uma outra forma de imprimir um resultado no console.writeline
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {

            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"\nO resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Potencia()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(v1, v2);

            Console.WriteLine($"O resultado da potência é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("------- MENU -------");
            Console.WriteLine("Selecione a a opção que deseja");
            Console.WriteLine("\n1 - Soma \n2 - Subtração \n3 - Divisão \n4 - Multiplicação \n5 - Potencia \n9 - Sair\n--------------------\n");

            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potencia(); break;
                case 9: System.Environment.Exit(0); break; //esse comando sai da aplicação
                default: Menu(); break;
            }
        }
    }
}