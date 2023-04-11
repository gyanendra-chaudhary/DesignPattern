using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_CS.CreationalPatterns.AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client testing first factory method");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();
            Console.WriteLine("Client testing second factory method");
            ClientMethod(new ConcreteFactory2());
        }
        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

    }

}
