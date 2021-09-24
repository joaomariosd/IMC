using System;
using System.Globalization;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Programa que calcula o IMC de uma pessoa!");
            Console.WriteLine();

            Paciente pac = new Paciente();

            Console.Write("Digite o nome do paciente: ");
            pac.Nome = Console.ReadLine();

            Console.Write("Digite a idade do paciente: ");
            pac.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o peso do paciente: ");
            pac.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a altura do paciente: ");
            pac.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();            

            double imc = pac.Peso / Math.Pow(pac.Altura, 2);

            if (imc < 18.5)
            {
                Console.WriteLine(pac);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Peso abaixo do normal!");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine(pac);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Peso normal!");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine(pac);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Sobre peso!");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine(pac);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Grau obsidade");
            }
            else if (imc > 40)
            {
                Console.WriteLine(pac);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Obsidade Grave");
                
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Fim!");
            Console.ReadKey();
        }
    }
}
