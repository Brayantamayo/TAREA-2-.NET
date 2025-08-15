using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el DNI del cliente: ");
            long dni = long.Parse(Console.ReadLine());

            Console.Write("Introduce el saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Introduce el interés anual (%): ");
            double interes = double.Parse(Console.ReadLine());

            cuenta miCuenta = new cuenta(dni, saldo, interes);

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Ingresar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Actualizar saldo");
                Console.WriteLine("4. Mostrar datos");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Cantidad a ingresar: ");
                        double ingreso = double.Parse(Console.ReadLine());
                        miCuenta.Ingresar(ingreso);
                        break;
                    case 2:
                        Console.Write("Cantidad a retirar: ");
                        double retiro = double.Parse(Console.ReadLine());
                        miCuenta.Retirar(retiro);
                        break;
                    case 3:
                        miCuenta.ActualizarSaldo();
                        Console.WriteLine("Saldo actualizado con interés diario.");
                        break;
                    case 4:
                        miCuenta.MostrarDatos();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 0);

        }
    }
    class cuenta
    {
        // atributos
        private long numerocuenta;
        private long dnicliente;
        private double saldoAtual;
        private double interesAnual;

        ///contructor por defecto
        //public cuenta()
        //{
        //    numerocuenta = geenerarnumerodecuenta();
        //    dnicliente = 0;
        //    saldoAtual = 0;
        //    interesAnual = 0;
        //}

        ////CONTRUCTOR CON PARAMETROS
        ///ejemplo
        ///Cuenta miCuenta = new Cuenta(98765432, 1000, 3.5);
        public cuenta(long dni, double saldo, double interes)
        {
            numerocuenta = new Random().Next(10000000, 99999999);
            dnicliente = dni;
            saldoAtual = saldo;
            interesAnual = interes;
        }


        private long geenerarnumerodecuenta()
        {
            Random rnd = new Random();
            // Genera un número largo concatenando dos partes aleatorias
            string numero = rnd.Next(10000000, 99999999).ToString() + rnd.Next(10000000, 99999999).ToString();
            return long.Parse(numero);
        }

        // Accesores y mutadores

        public long NumeroCuenta
        {
            get { return numerocuenta; } // Solo lectura
        }

        public long DniCliente
        {
            get { return dnicliente; }
            set { dnicliente = value; }
        }

        public double SaldoActual
        {
            get { return saldoAtual; }
            set { saldoAtual = value; }
        }

        public double InteresAnual
        {
            get { return interesAnual; }
            set { interesAnual = value; }
        }

        // Método para actualizar saldo aplicando interés diario
        public void ActualizarSaldo()
        {
            double interesDiario = interesAnual / 365;
            saldoAtual += saldoAtual * (interesDiario / 100);
        }

        // Ingresar dinero
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldoAtual += cantidad;
                //Toma el valor actual de la variable saldoActual.
                ////Le suma el valor de cantidad
                ///Guarda el resultado nuevamente en saldoActual.
                Console.WriteLine($"Ingresados {cantidad}€ correctamente.");
            }
            else
            {
                Console.WriteLine("La cantidad a ingresar debe ser positiva.");
            }
        }



        // Retirar dinero
        public void Retirar(double cantidad)
        {
            ////“Se permite la operación si la cantidad a retirar es menor o igual al saldo y además es mayor que 0.”
            if (cantidad <= saldoAtual && cantidad > 0)
            {
                saldoAtual -= cantidad;
                Console.WriteLine($"Retirados {cantidad}€ correctamente.");
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo o cantidad inválida.");
            }
        }




        // Mostrar todos los datos de la cuenta
        public void MostrarDatos()
        {
            Console.WriteLine("\n--- Datos de la Cuenta ---");
            Console.WriteLine($"Número de Cuenta: {numerocuenta}");
            Console.WriteLine($"DNI Cliente: {dnicliente}");
            Console.WriteLine($"Saldo Actual: {saldoAtual}");
            Console.WriteLine($"Interés Anual: {interesAnual}");
        }
    }














}

