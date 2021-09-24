using System;
using System.Collections.Generic;
using System.Globalization;

namespace Treinamento
{
    class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Paciente()
        {

        }

        public Paciente(string nome, int idade, double peso, double altura)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
        }

        public double Imc()
        {
           return Peso / Math.Pow(Altura, 2);
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Idade: " + Idade + " Anos " 
                + " Peso: " + Peso.ToString("F2", CultureInfo.InvariantCulture) + "kg " 
                + " Altura: " + Altura.ToString("F2", CultureInfo.InvariantCulture) + "cm";
        }
    }
}
