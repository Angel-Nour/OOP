using Mediator.request;

namespace Mediator;

public class Calendar : Component
{
    public Calendar(IMediator mediator) : base(mediator) { }

    public void NewDay(DayOfWeek day)
    {
        Mediator.Notify(new CalendarRequest(day));
    }
}