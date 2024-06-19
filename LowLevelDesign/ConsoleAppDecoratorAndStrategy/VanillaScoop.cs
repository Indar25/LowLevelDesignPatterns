namespace ConsoleAppDecoratorAndStrategy
{
    internal class VanillaScoop : IIngredient
    {
        private readonly IIngredient _ingredient;

        public VanillaScoop()
        {

        }
        public VanillaScoop(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }

        public string GetDiscription()
        {
            return _ingredient?.GetDiscription() + " VanillaScoop";
        }

        public double GetPrice()
        {
            return (_ingredient?.GetPrice() ?? 0) + 45;
        }
    }
}
