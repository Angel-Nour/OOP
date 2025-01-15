namespace Mediator;

public class Alarm: Component
{
    private int _alarmTime;

    public void SetAlarmTime(bool isWeekend)
    {
        _alarmTime = isWeekend ? 8 : 7;
        Console.WriteLine($"Будильник установлен на {_alarmTime}:00.");
    }

    public void Ring()
    {
        Console.WriteLine($"Будильник звенит в {_alarmTime}:00.");
        _mediator.Notify(this, "AlarmRang");
    }

    public void NotifyTime(int hour)
    {
        Console.WriteLine($"Сейчас {hour}:00.");
        _mediator.Notify(this, $"HourPassed-{hour}");
    }
}