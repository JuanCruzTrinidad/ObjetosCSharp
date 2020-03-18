using ObjetosCSharp.Geometrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosCSharp
{
    public class Menu
    {
        private int opcion { get; set; }

        public Menu() { }

        public void MostrarMenu(int opcion)
        {
            while (opcion != 10)
            {
                Console.Clear();
                Console.WriteLine("Elija la figura a calcular.");
                Console.WriteLine("1-Cuadrado");
                Console.WriteLine("2-Triangulo");
                Console.WriteLine("3-Rectangulo");
                Console.WriteLine("10-Salir del programa");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (ValidarOpcion(opcion) == true)
                {
                    if (opcion == 1)
                    {
                        Figura cuadrado = new Cuadrado();
                    }
                    else if (opcion == 2)
                    {
                        Figura triangulo = new Triangulo();
                    }
                    else if (opcion == 3)
                    {
                        Figura rectangulo = new Rectangulo();
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida");
                    Console.ReadKey();
                }
            }
        }

        public bool ValidarOpcion(int opcion)
        {
            if ((opcion >= 1 && opcion <= 3) || opcion == 10)
            {
                return true;
            }

            return false;
        }
    }
}
