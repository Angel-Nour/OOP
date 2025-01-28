namespace Mediator.request;

public class AlarmRequest : IRequest
{
    public TimeOnly Time { get; }

    public AlarmRequest(TimeOnly time)
    {
        Time = time;
    }
}