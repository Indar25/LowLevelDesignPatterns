namespace ConsoleAppDecoratorAndStrategy
{
    internal class ChocolateSyrup : IIngredient
    {
        private readonly IIngredient _ingredient;

        public ChocolateSyrup()
        {

        }
        public ChocolateSyrup(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }

        public string GetDiscription()
        {
            return _ingredient?.GetDiscription() + " ChocolateSyrup";
        }

        public double GetPrice()
        {
            return (_ingredient?.GetPrice() ?? 0) + 15;
        }
    }
}
