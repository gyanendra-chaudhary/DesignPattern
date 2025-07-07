using AbstractFactory;

Console.Title = "Abstract Factory";
var nepalShoppingCartPurchaseFactory = new NepalShoppingCartPurchaseFactory();
var shoppingCartForNepal = new ShoppingCart(nepalShoppingCartPurchaseFactory);
shoppingCartForNepal.CalculateCosts();

var indiaShoppingCartPurchaseFactory = new IndiaShoppingCartPurchaseFactory();
var shoppingCartForIndia = new ShoppingCart(indiaShoppingCartPurchaseFactory);
shoppingCartForIndia.CalculateCosts();
