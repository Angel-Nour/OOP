namespace AbstractFactory;

public class BucuriaSweetsFactory : ISweetsFactory
{
    public IChocolate GetChocolate()
    {
        return new BucuriaChocolate();
    }

    public ICaramel GetCaramel()
    {
        return new BucuriaCaramel();
    }

    public ILollipops GetLollipops()
    {
        return new BucuriaLollipops();
    }
}