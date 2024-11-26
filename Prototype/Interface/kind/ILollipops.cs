namespace AbstractFactory;

public interface ILollipops : IProduct
{
    string Try();
    ILollipops Clone();
}