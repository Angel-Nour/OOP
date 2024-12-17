namespace Decorator;

public abstract class Add : ICoffee
{
    protected ICoffee _coffee;

    protected Add(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public abstract double AddCost();
    
    public double Cost()
    {
        return _coffee.Cost() + this.AddCost();
    }
}