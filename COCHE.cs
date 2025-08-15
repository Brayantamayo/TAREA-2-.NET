using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();

            miCoche.motor.Arrancar();
            miCoche.rueda1.Inflar();
            miCoche.puerta1.Abrir();
            miCoche.puerta1.ventana.Abrir();
            miCoche.motor.Apagar();


        }
        class Motor
        {
            public void Arrancar() => Console.WriteLine("Motor arrancado.");
            public void Apagar() => Console.WriteLine("Motor apagado.");
        }

        class Rueda
        {
            public void Inflar() => Console.WriteLine("Rueda inflada.");
            public void Desinflar() => Console.WriteLine("Rueda desinflada.");
        }

        class Ventana
        {
            public void Abrir() => Console.WriteLine("Ventana abierta.");
            public void Cerrar() => Console.WriteLine("Ventana cerrada.");
        }

        class Puerta
        {
            public Ventana ventana = new Ventana();

            public void Abrir() => Console.WriteLine("Puerta abierta.");
            public void Cerrar() => Console.WriteLine("Puerta cerrada.");
        }

        class Coche
        {
            public Motor motor = new Motor();
            public Rueda rueda1 = new Rueda();
            public Rueda rueda2 = new Rueda();
            public Rueda rueda3 = new Rueda();
            public Rueda rueda4 = new Rueda();
            public Puerta puerta1 = new Puerta();
            public Puerta puerta2 = new Puerta();
        }
    }
}
