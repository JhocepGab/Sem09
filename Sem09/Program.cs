using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyejemplClass09;

namespace Sem09
{
    class Program
    {
        static void Main(string[] args)
        {
            Areas a = new Areas();
            Console.WriteLine("ingrese el lado: ");
            double x = double.Parse(Console.ReadLine());
            double r1 = a.AreaCuadrado(x);
            Console.WriteLine("El area del cuadrado es: " + r1);

            
            double r2 = a.AreaCirculo(9);
            Console.WriteLine("El area del circulo es: " + r2);

            Perimetros p = new Perimetros();

            double r, r3=0;

            Console.WriteLine("ingresa el radio: ");
            r = double.Parse(Console.ReadLine());

            p.PerimetroDelCircule(r, ref r3);
            Console.WriteLine("R3: " + r3);
        }
    }
}
