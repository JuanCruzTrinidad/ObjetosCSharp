using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosCSharp
{
    public abstract class Figura
    {
        protected List<String> Medidas { get; set; }
    
        public Figura ()
        {
            Medidas = new List<string>();
            
        }
        public abstract void CalcularArea();
     
    }
}
