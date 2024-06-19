namespace ConsoleAppDecoratorAndStrategy
{
    internal class OrangeCone : IIngredient
    {
        public OrangeCone()
        {
            
        }
        private readonly IIngredient _ingredient;

        public OrangeCone(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }
        public string GetDiscription()
        {
            return _ingredient?.GetDiscription() + " OrangeCone";
        }

        public double GetPrice()
        {
            return (_ingredient?.GetPrice() ?? 0) + 50;
        }
    }
}
