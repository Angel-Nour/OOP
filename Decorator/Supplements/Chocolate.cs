namespace Decorator;

public class Chocolate : Additions
{
    public Chocolate(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return 7;
    }
}