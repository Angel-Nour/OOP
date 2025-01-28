using Mediator.request;

namespace Mediator;

public class Alarm : Component
{
    public Alarm(IMediator mediator) : base(mediator) { }

    public void NotifyTime(TimeOnly currentHour)
    {
        Mediator.Notify(new AlarmRequest(currentHour));
    }

    public void SetAlarmTime(CalendarRequest requests)
    {
        var alarmTime = requests.IsWeekend ? 8 : 7;
        Console.WriteLine($"Будильник: Звонок в {alarmTime}:00.");
    }
}
