namespace Decorator;

public class Discount : Additions
{
    public Discount(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return -_coffee.Cost() * 0.07;
    }
}