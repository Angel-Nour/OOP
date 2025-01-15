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

    public void Notify(object sender, string eventInfo)
    {
        if (sender == _calendar && eventInfo == "NewDay")
        {
            bool isWeekend = _calendar.IsWeekend;
            _alarm.SetAlarmTime(isWeekend);
            _irrigationSystem.ScheduleIrrigation(_calendar.DayOfWeek);
        }
        else if (sender == _alarm && eventInfo == "AlarmRang")
        {
            _coffeeMachine.CheckAndPrepareCoffee(_calendar.DayOfWeek);
        }
        else if (sender == _alarm && eventInfo.StartsWith("HourPassed"))
        {
            int hour = int.Parse(eventInfo.Split('-')[1]);
            _irrigationSystem.CheckIrrigation(hour, _calendar.DayOfWeek);
        }
    }
}