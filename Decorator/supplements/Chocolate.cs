namespace Decorator;

public class Chocolate : Add
{
    public Chocolate(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 7;
    }
}