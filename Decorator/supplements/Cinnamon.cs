namespace Decorator;

public class Cinnamon : Add
{
    public Cinnamon(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 5;
    }
}