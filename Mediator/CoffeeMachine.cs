namespace Mediator;

public abstract class CoffeeMachine : Component
{
    public static void CheckAndPrepareCoffee(DayOfWeek day)
    {
        if (day == DayOfWeek.Saturday)
        {
            Console.WriteLine("Кофемашина готовит кофе.");
        }
    }
}