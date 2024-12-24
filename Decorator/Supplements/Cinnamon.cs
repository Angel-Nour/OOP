namespace Decorator.Supplements;

public class Cinnamon : Supplements
{
    public Cinnamon(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 5;
    }
}