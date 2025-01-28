namespace Mediator.request;

public class CalendarRequest : IRequest
{
    public DayOfWeek Day { get; }
    public bool IsWeekend { get; }

    public CalendarRequest(DayOfWeek day)
    {
        Day = day;
        IsWeekend = day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
    }
}