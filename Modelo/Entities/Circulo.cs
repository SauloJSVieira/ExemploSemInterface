using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSemInterface.Modelo.Entities
{
    internal class Circulo : Formas
    {
        public double Raio { get; set; }

        public override double Area() 
        { 
            return Math.PI * Raio * Raio;
        }
        public override string ToString()
        {
            return
                "\n\nCirculo\n\nRaio: "
                + Raio.ToString("f2", CultureInfo.InvariantCulture) +                
                ", Área do Circulo: "
                + Area().ToString("f2", CultureInfo.InvariantCulture) +
                ", Cor: "
                + Cor;
        }
    }
}
