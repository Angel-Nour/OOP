using Decorator.Coffee;

namespace Decorator.Supplements;

public abstract class Supplements : ICoffee
{
   private protected ICoffee _coffee;

    protected Supplements(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public abstract double AddCost();
    
    public double Cost()
    {
        return _coffee.Cost() + this.AddCost();
    }
}