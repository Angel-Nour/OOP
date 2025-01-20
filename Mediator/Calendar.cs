using Mediator.request;

namespace Mediator;

public abstract class Calendar : Component
{
    public DayOfWeek DayOfWeek { get; private set; }
    public bool IsWeekend => DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;

    public void NewDay(DayOfWeek dayOfWeek)
    {
        DayOfWeek = dayOfWeek;
        Console.WriteLine($"Новый день: {dayOfWeek}.");
        NotifyMediator(new NewDayRequest(dayOfWeek));
    }
}