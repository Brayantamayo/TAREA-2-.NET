using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n1 de la primera fracción: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("n2 de la primera fracción: ");
            int b1 = int.Parse(Console.ReadLine());

            Console.Write("n1 de la segunda fracción: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("n2 de la segunda fracción: ");
            int b2 = int.Parse(Console.ReadLine());

            Racional r1 = new Racional(a1, b1);
            Racional r2 = new Racional(a2, b2);

            Console.WriteLine("\nSuma: " + r1.Sumar(r2));
            Console.WriteLine("Resta: " + r1.Restar(r2));
            Console.WriteLine("Multiplicación: " + r1.Multiplicar(r2));
            Console.WriteLine("División: " + r1.Dividir(r2));

        }
        class Racional
        {
            public int n1; // numerador
            public int n2; // denominador

            public Racional(int a, int b)
            {
                n1 = a;
                n2 = b;
            }

            public Racional Sumar(Racional otro)
            {
                int a = n1 * otro.n2 + n2 * otro.n1;
                int b = n2 * otro.n2;
                return new Racional(a, b);
            }

            public Racional Restar(Racional otro)
            {
                int a = n1 * otro.n2 - n2 * otro.n1;
                int b = n2 * otro.n2;
                return new Racional(a, b);
            }

            public Racional Multiplicar(Racional otro)
            {
                int a = n1 * otro.n1;
                int b = n2 * otro.n2;
                return new Racional(a, b);
            }

            public Racional Dividir(Racional otro)
            {
                int a = n1 * otro.n2;
                int b = n2 * otro.n1;
                return new Racional(a, b);
            }

            public override string ToString()
            {
                return n1 + "/" + n2;
            }
        }

    }
}
