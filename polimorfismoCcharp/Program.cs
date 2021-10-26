using System;

namespace polimorfismoCcharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Quadrado quadrado = new Quadrado("quadrado", 5, 5);
            Console.WriteLine(quadrado.calcularArea.ToString());
            //area = 5 * 5


            Triangulo triangulo = new Triangulo("triangulo", 10, 15);
            Console.WriteLine(triangulo.calcularArea.ToString());
            //area = 10 * 15 / 2
        }
    }
}
