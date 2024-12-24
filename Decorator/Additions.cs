namespace Decorator;

public abstract class Additions : ICoffee
{
   private protected ICoffee _coffee;

    protected Additions(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public abstract double AddCost();
    
    public double Cost()
    {
        return _coffee.Cost() + this.AddCost();
    }
}