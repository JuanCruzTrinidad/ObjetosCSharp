using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosCSharp.Geometrica
{
    class Triangulo: Figura
    {
        private List<Double> parametros = new List<double>();
        public Triangulo()
            : base()
        {
            Console.WriteLine("Ingrese la medida de la base del triangulo:");
            Medidas.Add(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la altura del triangulo:");
            Medidas.Add(Console.ReadLine());
            CalcularArea();
        }

        public override void CalcularArea()
        {
            foreach (var medida in this.Medidas)
            {
                parametros.Add(Convert.ToDouble(medida));
            }
            double superficie = ((parametros[0] * parametros[1]) /2);
            Console.WriteLine($"La superficie del triangulo es de: {superficie}");
            Console.ReadKey();
        }
    }
}
