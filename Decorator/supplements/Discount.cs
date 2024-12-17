namespace Decorator;

public class Discount : Add
{
    public Discount(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return -_coffee.Cost() * 0.07;
    }
}