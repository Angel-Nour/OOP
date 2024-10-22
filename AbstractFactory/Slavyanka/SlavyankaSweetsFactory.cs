namespace AbstractFactory;

public class SlavyankaSweetsFactory : ISweetsFactory
{
    private SlavyankaSweetsFactory() { }
    private static SlavyankaSweetsFactory _instance;
    public static SlavyankaSweetsFactory Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SlavyankaSweetsFactory();
            }
            return _instance;
        }
    }
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