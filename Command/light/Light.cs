namespace Command.light;

public class Light
{
    private bool _isOn;

    public void OnOff()
    {
        _isOn = !_isOn;
        Console.WriteLine(_isOn ? "Свет включен" : "Свет выключен");
    }
}