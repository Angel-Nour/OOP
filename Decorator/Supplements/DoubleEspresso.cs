using Decorator.Coffee;

namespace Decorator.Supplements;

public class DoubleEspresso : Supplements
{
    public DoubleEspresso(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 12;
    }
}