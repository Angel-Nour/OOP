using Mediator.request;

namespace Mediator;

public class CoffeeMachine : Component
{
    public CoffeeMachine(IMediator mediator) : base(mediator) { }

    public void CheckAndPrepareCoffee(AlarmRequest request)
    {
        if (request.Time.Hour == 8)
        {
            Console.WriteLine("Кофемашина: Готовлю кофе в 8.");
        }
    }
}
