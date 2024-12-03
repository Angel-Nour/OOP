namespace AbstractFactory;

public class SlavyankaSweetsFactory : ISweetsFactory
{
    private IChocolate _chocolatePrototype;
    private ICaramel _caramelPrototype;
    private ILollipops _lollipopsPrototype;

    public SlavyankaSweetsFactory()
    {
        _chocolatePrototype = new SlavyankaChocolate();
        _caramelPrototype = new SlavyankaCaramel();
        _lollipopsPrototype = new SlavyankaLollipops();
    }
    public IChocolate GetChocolate()
    {
        return _chocolatePrototype.Clone();
    }

    public ICaramel GetCaramel()
    {
        return _caramelPrototype.Clone();
    }

    public ILollipops GetLollipops()
    {
        return _lollipopsPrototype.Clone();
    }
}