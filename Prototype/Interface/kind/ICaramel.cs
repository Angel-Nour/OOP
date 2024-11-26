namespace AbstractFactory;

public interface ICaramel: IProduct
{
    string Try();
    ICaramel Clone();
}