using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;

    }
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;
        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "BE":
                        return 20;
                    case "NP":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;
        public CodeDiscountService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPercentage
        {
            get => 15;
        }
    }

    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }
    /// <summary>
    /// ContentCreator
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;
        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier= countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }
    /// <summary>
    /// ContentCreator
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFactory(Guid code)
        {
            _code= code;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }

    
}
