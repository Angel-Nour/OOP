using Decorator.Coffee;

namespace Decorator.Supplements;

public class Chocolate : Supplements
{
    public Chocolate(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 7;
    }
}