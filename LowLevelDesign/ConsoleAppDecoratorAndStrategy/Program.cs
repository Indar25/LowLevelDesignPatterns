using System;

namespace ConsoleAppDecoratorAndStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IIngredient icecream = new ChocolateScoop(new StrawberryScoop(
                                                new VanillaScoop(
                                                    new OrangeCone(new ChocolateSyrup
                                                    (new ChocolateCone())))));

            Console.WriteLine(icecream.GetPrice());
            Console.WriteLine(icecream.GetDiscription());

            Console.WriteLine("Hello World!");
        }
    }
}
