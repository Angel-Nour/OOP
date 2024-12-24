namespace Decorator;

public class DoubleEspresso : Additions
{
    public DoubleEspresso(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 12;
    }
}