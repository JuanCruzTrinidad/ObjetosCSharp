using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosCSharp.Geometrica
{
    public class Cuadrado : Figura
    {
        private List<Double> parametros = new List<double>();
        public Cuadrado()
            : base()
        {
            Console.WriteLine("Ingrese la medida del lado del cuadrado:");
            Medidas.Add(Console.ReadLine());
            CalcularArea();
        }

        public override void  CalcularArea()
        {
            foreach (var medida in this.Medidas)
            {
                parametros.Add(Convert.ToDouble(medida));
            }
            double superficie = parametros[0] * parametros[0];
            Console.WriteLine($"La superficie del cuadrado es de: {superficie}");
            Console.ReadKey();
        }
    }
}
