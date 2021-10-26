using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismoCcharp
{
    class Quadrado : Figura
    {

        /*
         * O metodo @calcularArea e reimplementado com o atributo @override,
         * a funcao agora retorna o calculo da area do quadrado de acordo com o lado
         * 
         * lado * lado
         * **/
        public override Double calcularArea { get
            {
                this.Area = this.Lado * this.Lado;
                return this.Area;
            }
        }

        public Quadrado(string nome, double lado, double altura) : base(nome, lado, altura)
        {
        }
    }
}
