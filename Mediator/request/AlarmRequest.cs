namespace Mediator.request;

public class AlarmRequest : IRequest
{
    public int AlarmTime { get; }
    public AlarmRequest(int alarmTime)
    {
        AlarmTime = alarmTime;
    }
}