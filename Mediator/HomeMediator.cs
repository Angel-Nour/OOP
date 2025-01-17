using Mediator.request;

namespace Mediator;

public class HomeMediator : IMediator
{
    private Alarm _alarm;
    private CoffeeMachine _coffeeMachine;
    private IrrigationSystem _irrigationSystem;
    private Calendar _calendar;

    public void SetComponents(Alarm alarm, CoffeeMachine coffeeMachine, IrrigationSystem irrigationSystem, Calendar calendar)
    {
        _alarm = alarm;
        _coffeeMachine = coffeeMachine;
        _irrigationSystem = irrigationSystem;
        _calendar = calendar;

        _alarm.SetMediator(this);
        _coffeeMachine.SetMediator(this);
        _irrigationSystem.SetMediator(this);
        _calendar.SetMediator(this);
    }

    public void Notify(object sender, IRequest request)
    {
        switch (request)
        {
            case NewDayRequest newDayRequest:
                bool isWeekend = newDayRequest.Day == DayOfWeek.Saturday || newDayRequest.Day == DayOfWeek.Sunday;
                _alarm.SetAlarmTime(isWeekend);
                IrrigationSystem.ScheduleIrrigation(newDayRequest.Day);
                break;

            case AlarmRequest alarmRequest:
                CoffeeMachine.CheckAndPrepareCoffee(_calendar.DayOfWeek);
                break;

            case TimePassedRequest timePassedRequest:
                _irrigationSystem.CheckIrrigation(timePassedRequest.Hour, _calendar.DayOfWeek);
                break;
        }
    }
}