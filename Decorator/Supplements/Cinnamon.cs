namespace Decorator;

public class Cinnamon : Additions
{
    public Cinnamon(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 5;
    }
}