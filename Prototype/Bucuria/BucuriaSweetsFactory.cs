namespace AbstractFactory;

public class BucuriaSweetsFactory : ISweetsFactory
{
    private IChocolate _chocolatePrototype;
    private ICaramel _caramelPrototype;
    private ILollipops _lollipopsPrototype;

    public BucuriaSweetsFactory()
    {
        _chocolatePrototype = new BucuriaChocolate();
        _caramelPrototype = new BucuriaCaramel();
        _lollipopsPrototype = new BucuriaLollipops();
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