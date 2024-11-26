namespace AbstractFactory;

public class BucuriaSweetsFactory : ISweetsFactory
{
    private IChocolate _chocolatePrototype;
    private ICaramel _caramelPrototype;
    private ILollipops _lollipopsPrototype;

    public BucuriaSweetsFactory(BucuriaChocolate chocolate, BucuriaCaramel caramel, BucuriaLollipops lollipops)
    {
        _chocolatePrototype = chocolate == null ? throw new ArgumentNullException() : chocolate;
        _caramelPrototype = caramel == null ? throw new ArgumentNullException() : caramel;
        _lollipopsPrototype = lollipops == null ? throw new ArgumentNullException() : lollipops;
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