namespace ConsoleAppDecoratorAndStrategy
{
    public class StrawberrySyrup : IIngredient
    {
        private readonly IIngredient _ingredient;

        public StrawberrySyrup(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }

        public StrawberrySyrup()
        {

        }
        public string GetDiscription()
        {
            return _ingredient?.GetDiscription() + " StrawberrySyrup";
        }

        public double GetPrice()
        {
            return (_ingredient?.GetPrice() ?? 0) + 20;
        }
    }
}
