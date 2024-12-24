namespace Decorator.Supplements;

public class Discount : Supplements
{
    public Discount(ICoffee coffee) : base(coffee)
    {
    }

    public override double AddCost()
    {
        return -_coffee.Cost() * 0.07;
    }
}