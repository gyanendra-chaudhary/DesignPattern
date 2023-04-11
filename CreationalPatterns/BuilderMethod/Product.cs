using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_CS.CreationalPatterns.BuilderMethod
{
    public class Product
    {
        private List<Object> _parts = new List<Object>();
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string st = string.Empty;
            for(int i = 0; i<this._parts.Count; i++)
            {

            }
        }
    }
}
