using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismoCcharp
{
    abstract class Figura
    {
        private String nome;
        private Double lado;
        private Double altura;
        private Double area = 0;

        /*
         * @calcularArea é uma função abstrata, assim podemos a reescrever
         * mudando totalmente seu sentido.
         * 
         * **/
        public abstract double calcularArea { get; }

        public Figura(string nome, double lado, double altura)
        {
            this.Nome = nome;
            this.Lado = lado;
            this.Altura = altura;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Lado { get => lado; set => lado = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Area { get => area; set => area = value; }
    }
}
