namespace Decorator;

public class DoubleEspresso : Add
{
    public DoubleEspresso(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 12;
    }
}