namespace AbstractFactory;

public interface IChocolate : IProduct
{
    string Try();
    IChocolate Clone();
}