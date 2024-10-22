namespace AbstractFactory;

public class RoshenSweetsFactory : ISweetsFactory
{
    private RoshenSweetsFactory() { }
    private static RoshenSweetsFactory _instance;
    public static RoshenSweetsFactory Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new RoshenSweetsFactory();
            }
            return _instance;
        }
    }
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