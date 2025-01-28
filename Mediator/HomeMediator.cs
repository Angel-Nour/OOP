using Mediator.request;

namespace Mediator;

public class HomeMediator : IMediator
{
    private readonly Alarm _alarm;
    private readonly CoffeeMachine _coffeeMachine;
    private readonly IrrigationSystem _irrigationSystem;
    private readonly Calendar _calendar;

    public HomeMediator(Alarm alarm, CoffeeMachine coffeeMachine, IrrigationSystem irrigationSystem, Calendar calendar)
    {
        _alarm = alarm;
        _coffeeMachine = coffeeMachine;
        _irrigationSystem = irrigationSystem;
        _calendar = calendar;
    }

    public void Notify(IRequest request)
    {
        switch (request)
        {
            case CalendarRequest calendarRequest:
                _alarm.SetAlarmTime(calendarRequest);
                _irrigationSystem.ScheduleIrrigation(calendarRequest);
                break;

            case AlarmRequest alarmRequest:
                _irrigationSystem.CheckIrrigation(alarmRequest, DateTime.Now.DayOfWeek);
                _coffeeMachine.CheckAndPrepareCoffee(alarmRequest);
                break;
        }
    }
}