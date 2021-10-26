using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismoCcharp
{
    class Triangulo : Figura
    {

        /*
         * O metodo @calcularArea e reimplementado, mas, diferentemente do quadrado,
         * o metodo utiliza as duas formas de polimorfismo juntas, reescrevendo um novo
         * metodo, a partir da insercao de um novo parametro, e reimplementando o metodo
         * com um caso diferente
         * **/
        public override Double calcularArea { get 
            {
                this.Area = this.Lado * this.Altura / 2;
                return this.Area;
            }
        }

        public Triangulo(string nome, double lado, double altura) : base(nome, lado, altura)
        {
        }
    }
}
