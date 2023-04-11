using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_CS.CreationalPatterns.BuilderMethod
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new Product();
        }
        public void BuildPartA()
        {
            throw new NotImplementedException();
        }

        public void BuildPartB()
        {
            throw new NotImplementedException();
        }

        public void BuildPartC()
        {
            throw new NotImplementedException();
        }
        public Product GetProduct()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }
    }
}
