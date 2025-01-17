namespace Mediator.request;

public class NewDayRequest : IRequest
{
    public DayOfWeek Day { get; }
    public NewDayRequest(DayOfWeek day)
    {
        Day = day;
    }
}