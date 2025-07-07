using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface IShopingCarrtPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShoppingCostService CreateShoppingCostService();
    }

    /// <summary>
    /// AbstractProduct
    /// </summary>

    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }
    /// <summary>
    /// ConcreteProduct
    /// </summary>

    public class NepalDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class IndiaDiscountService : IDiscountService
    {
        public int DiscountPercentage => 1;
    }

    /// <summary>
    /// AbstractProduct
    /// </summary>

    public interface IShoppingCostService
    {
        decimal ShippingCosts { get; }
    }
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class NepalShoppingCostService : IShoppingCostService
    {
        public decimal ShippingCosts => 10;
    }
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class IndiaShoppingCostService : IShoppingCostService
    {
        public decimal ShippingCosts => 15;
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class NepalShoppingCartPurchaseFactory : IShopingCarrtPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new NepalDiscountService();
        }

        public IShoppingCostService CreateShoppingCostService()
        {
            return new NepalShoppingCostService();
        }
    }

    /// <summary>
    /// ConcreteFactory
    /// </summary>
    public class IndiaShoppingCartPurchaseFactory : IShopingCarrtPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new IndiaDiscountService();
        }

        public IShoppingCostService CreateShoppingCostService()
        {
            return new IndiaShoppingCostService();
        }
    }


    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShoppingCostService _shoppingCostService;
        private int _orderCosts;

        public ShoppingCart(IShopingCarrtPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shoppingCostService = factory.CreateShoppingCostService();
            _orderCosts = 200;
        }
        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts/100*_discountService.DiscountPercentage) + _shoppingCostService.ShippingCosts}");
        }
    }

}
