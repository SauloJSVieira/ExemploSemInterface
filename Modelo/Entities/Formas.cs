using ExemploSemInterface.Modelo.Enuns;

namespace ExemploSemInterface.Modelo.Entities
{
    internal abstract class Formas
    {
        public Cor Cor { get; set; }
        public abstract double Area();        
    }
}
