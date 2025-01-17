namespace Mediator.request;

public class TimePassedRequest : IRequest
{
    public int Hour { get; }
    public TimePassedRequest(int hour)
    {
        Hour = hour;
    }
}