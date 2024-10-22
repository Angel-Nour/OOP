namespace AbstractFactory;

public class BucuriaSweetsFactory : ISweetsFactory
{
    private BucuriaSweetsFactory() { }
    private static BucuriaSweetsFactory _instance;
    public static BucuriaSweetsFactory Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BucuriaSweetsFactory();
            }
            return _instance;
        }
    }
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