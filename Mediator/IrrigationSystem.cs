using Mediator.request;

namespace Mediator;

public class IrrigationSystem : Component
{
    private readonly int _irrigationInterval = 6;
    private int _lastIrrigationHour = -6;

    public IrrigationSystem(IMediator mediator) : base(mediator) { }

    public void CheckIrrigation(AlarmRequest request, DayOfWeek day)
    {
        if (day == DayOfWeek.Saturday)
        {
            Console.WriteLine("Суббота: Оросительная система не работает.");
            return;
        }

        if (request.Time.Hour - _lastIrrigationHour >= _irrigationInterval)
        {
            Console.WriteLine("Оросительная система включена.");
            _lastIrrigationHour = request.Time.Hour;
        }
    }

    public void ScheduleIrrigation(CalendarRequest day)
    {
        if (day.Day == DayOfWeek.Saturday)
        {
            Console.WriteLine("Суббота: Оросительная система не работает.");
            return;
        }

        Console.WriteLine("Оросительная система готова к включению через 6 часов.");
    }
}