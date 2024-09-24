namespace AbstractFactory;

public class RoshenSweetsFactory : ISweetsFactory
{
    public IChocolate GetChocolate()
    {
        return new RoshenChocolate();
    }

    public ICaramel GetCaramel()
    {
        return new RoshenCaramel();
    }

    public ILollipops GetLollipops()
    {
        return new RoshenLollipops();
    }
}