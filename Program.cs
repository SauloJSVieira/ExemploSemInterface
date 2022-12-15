using ExemploSemInterface.Modelo.Entities;
using ExemploSemInterface.Modelo.Enuns;

namespace ExemploSemInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Formas forma1 = new Retangulo() { Comprimento = 4.2, Largura = 3.5, Cor = Cor.Azul };
            Formas forma2 = new Circulo() { Cor = Cor.Vermelho, Raio = 2.0 };

            Console.WriteLine(forma1);
            Console.WriteLine(forma2);
        }
    }
}