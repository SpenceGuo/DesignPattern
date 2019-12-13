namespace FactoryMethodSample
{
    interface Product
    {

    }

    class ConcreteProduct : Product
    {

    }

    interface Factory
    {
        Product FactoryMethod();
    }

    class ConcreteFactory : Factory 
    {
        public Product FactoryMethod() 
        {
            return new ConcreteProduct();
        }
    }
}
