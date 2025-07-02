using Singleton;

Console.Title= "Singleton Pattern Example";

//var logger = Logger();
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if(instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Both instances are the same.");
}
else
{
    Console.WriteLine("Instances are different.");
}

instance1.Log($"Message from {nameof(instance1)}");
instance1.Log($"Message from {nameof(instance2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");

Console.ReadLine();
