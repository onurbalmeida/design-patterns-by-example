namespace AbstractFactoryPattern.CompositionExample.Factory
{
    using AbstractFactory;
    using ConcreteProduct;

    public class MercedesFactory : IFactory
    {
        public MercedesFactory()
        {
        }

        public ICar Create(string model)
        {
            return new Mercedes().CreateCar(model);
        }

        public bool IsNull()
        {
            return false;
        }
    }
}