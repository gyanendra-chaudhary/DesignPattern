using DesignPattern.CreationalPatterns.FactoryMethod;
using DesignPattern_CS.CreationalPatterns.AbstractFactory;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Shoe().Main();
            new Client().Main();
        }
    }
}