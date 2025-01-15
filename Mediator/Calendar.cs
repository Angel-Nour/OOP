namespace Mediator;

public class Calendar : Component
{
    public DayOfWeek DayOfWeek { get; private set; }
    public bool IsWeekend => DayOfWeek == DayOfWeek.Saturday || DayOfWeek == DayOfWeek.Sunday;

    public void NewDay(DayOfWeek dayOfWeek)
    {
        DayOfWeek = dayOfWeek;
        Console.WriteLine($"Новый день: {dayOfWeek}.");
        _mediator.Notify(this, "NewDay");
    }
}