using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    interface IShoe
    {
        string Creation();
    }
    abstract class ShoeCreator
    {
        public abstract IShoe FactoryMethod();
        public string TestShoe()
        {
            var shoe = FactoryMethod();
            var result = "Creator: the same creator's code has just worked with " + shoe.Creation();
            return result;
        }
    }
    class ShoeCreatorAdidas : ShoeCreator
    {
        public override IShoe FactoryMethod()
        {
            return new ShoeAdidas();
        }
    }
    class ShoeCreatorJordan : ShoeCreator
    {
        public override IShoe FactoryMethod()
        {
            return new ShoeJordan();
        }
    }
    class ShoeAdidas : IShoe
    {
        public string Creation()
        {
            return "{Result of Shoe Adidas}";
        }
    }
    class ShoeJordan : IShoe
    {
        public string Creation()
        {
            return "{Result of Shoe Jordan}";
        }
    }
    class Shoe
    {
        public void Main()
        {
            Console.WriteLine("start");
            ShoeCode(new ShoeCreatorAdidas());
            Console.WriteLine("start");
            ShoeCode(new ShoeCreatorJordan());
        }
        public void ShoeCode(ShoeCreator shoeCreator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + shoeCreator.TestShoe());
        }
    }


}
