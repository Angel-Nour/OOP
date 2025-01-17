namespace Mediator;

public abstract class IrrigationSystem : Component
{
    private readonly int _irrigationInterval = 6;
    private int _lastIrrigationHour = -6;
    private int _currentDay = -1;

    public static void ScheduleIrrigation(DayOfWeek day)
    {
        if (day == DayOfWeek.Saturday)
        {
            Console.WriteLine("Суббота: оросительная система не работает.");
            return;
        }

        Console.WriteLine("Оросительная система готова к включению через 6 часов.");
    }

    public void CheckIrrigation(int currentHour, DayOfWeek day)
    {
        if (day == DayOfWeek.Saturday)
        {
            return;
        }

        if (_currentDay != (int)day)
        {
            _currentDay = (int)day;
            _lastIrrigationHour = -6;
        }

        if (currentHour - _lastIrrigationHour >= _irrigationInterval)
        {
            Console.WriteLine("Оросительная система включена.");
            _lastIrrigationHour = currentHour;
        }
    }
}