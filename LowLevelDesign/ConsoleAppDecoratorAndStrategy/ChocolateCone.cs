namespace ConsoleAppDecoratorAndStrategy
{
    internal class ChocolateCone : IIngredient
    {
        private readonly IIngredient _ingredient;
        public ChocolateCone()
        {

        }
        public ChocolateCone(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }
        public string GetDiscription()
        {
            return _ingredient?.GetDiscription() + " ChocolateCone";
        }

        public double GetPrice()
        {
            return (_ingredient?.GetPrice() ?? 0) + 60;
        }
    }
}
