namespace AbstractFactory;

public class SlavyankaSweetsFactory : ISweetsFactory
{
    public IChocolate GetChocolate()
    {
        return new SlavyankaChocolate();
    }

    public ICaramel GetCaramel()
    {
        return new SlavyankaCaramel();
    }

    public ILollipops GetLollipops()
    {
        return new SlavyankaLollipops();
    }
}