namespace ConsoleAppDecoratorAndStrategy
{
    internal class ChocolateScoop : IIngredient
    {
        private readonly IIngredient _ingredient;

        public ChocolateScoop()
        {

        }
        public ChocolateScoop(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }

        public string GetDiscription()
        {
            return _ingredient?.GetDiscription() + " ChocolateScoop";
        }

        public double GetPrice()
        {
            return (_ingredient?.GetPrice() ?? 0) + 40;
        }
    }
}
