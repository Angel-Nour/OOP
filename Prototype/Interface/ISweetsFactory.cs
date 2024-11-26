namespace AbstractFactory;

public interface ISweetsFactory
{
    IChocolate GetChocolate();
    ICaramel GetCaramel();
    ILollipops GetLollipops();
}