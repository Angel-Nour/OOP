namespace AbstractFactory;

public class RoshenSweetsFactory : ISweetsFactory
{
    private IChocolate _chocolatePrototype;
    private ICaramel _caramelPrototype;
    private ILollipops _lollipopsPrototype;

    public RoshenSweetsFactory()
    {
        _chocolatePrototype = new RoshenChocolate();
        _caramelPrototype = new RoshenCaramel();
        _lollipopsPrototype = new RoshenLollipops();
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