using System;


namespace ObjetosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionElegida = 0;
            Menu menu = new Menu();
            try
            {
                menu.MostrarMenu(opcionElegida);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                menu.MostrarMenu(opcionElegida);
            }

        }

    }
}
