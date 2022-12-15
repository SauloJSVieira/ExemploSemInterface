using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSemInterface.Modelo.Entities
{
    internal class Retangulo : Formas
    {
        public double Comprimento { get; set; }
        public double Largura { get; set; }      

        public override double Area() 
        {
            return Comprimento * Largura;
        }
        public override string ToString()
        {
            return
                "\nRETÂNGULO\n\nComprimento: "
                + Comprimento.ToString("f2", CultureInfo.InvariantCulture) +
                ", Largura: "
                + Largura.ToString("f2", CultureInfo.InvariantCulture) +
                ", Área do Retângulo: "
                + Area().ToString("f2", CultureInfo.InvariantCulture) +
                ", Cor: "
                + Cor;
        }
    }
}
