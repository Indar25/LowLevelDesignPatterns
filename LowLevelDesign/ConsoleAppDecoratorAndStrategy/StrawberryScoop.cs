namespace ConsoleAppDecoratorAndStrategy
{
    internal class StrawberryScoop : IIngredient
    {
        private readonly IIngredient _ingredient;
        public StrawberryScoop()
        {

        }

        public StrawberryScoop(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }

        public string GetDiscription()
        {
            return _ingredient?.GetDiscription() + " StrawberryScoop";
        }

        public double GetPrice()
        {
            return (_ingredient?.GetPrice() ?? 0) + 45;
        }
    }
}
