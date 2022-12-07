using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma operação ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("---------------------------------------");

            int resp = int.Parse(Console.ReadLine());


            Console.WriteLine("");

            switch (resp)
            {
                case 1:
                    Adicao();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Multiplicacao();
                    break;

                case 4:
                    Divisao();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Adicao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = valor1 + valor2;
            Console.Clear();
            // Console.Write("O resultado é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Ainda que eu fizesse mil poesias");
            Console.ReadLine();
            Console.WriteLine("Ou reunisse todos os poetas do mundo");
            Console.ReadLine();
            Console.WriteLine("Nenhum conseguiria descrever esse teu sorriso e olhos castanhos.");
            Console.ReadLine();
            Console.WriteLine("Val <3");
            Console.ReadLine();
            Menu();


        }
        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = valor1 - valor2;
            Console.Clear();
            // Console.Write("O resultado é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Vou te abraçar bem forte até sentir as batidas do seu coração ^^ ");
            Console.WriteLine("     ");
            Console.ReadLine();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(" ");
            double resultado = valor1 * valor2;
            Console.Clear();
            // Console.Write("O resultado é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Vc é como um tesouro escondido e eu sou o pirata com o mapa procurando e encontrando esse tesouro");
            Console.WriteLine(" ");
            Console.ReadLine();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = valor1 / valor2;
            Console.Clear();
            // Console.Write("O resultado é: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Um alguém ");
            Console.ReadLine();
            Console.WriteLine("Você! ");
            Console.ReadLine();
            Console.Write("Um mundo ");
            Console.ReadLine();
            Console.WriteLine("O seu! ");
            Console.ReadLine();
            Console.Write("Uma cor ");
            Console.ReadLine();
            Console.WriteLine("A dos teus olhos! ");
            Console.ReadLine();
            Console.Write("Um sabor ");
            Console.ReadLine();
            Console.WriteLine("O seu beijo ");
            Console.ReadLine();
            Console.Write("Um medo ");
            Console.ReadLine();
            Console.WriteLine("Perder você ");
            Console.ReadLine();
            Menu();
        }

    }
}

