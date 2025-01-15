namespace Mediator;

public class CoffeeMachine : Component
{
    public void CheckAndPrepareCoffee(DayOfWeek day)
    {
        if (day == DayOfWeek.Saturday)
        {
            Console.WriteLine("Кофемашина готовит кофе.");
        }
    }
}