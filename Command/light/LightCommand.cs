namespace Command.light;

public class LightCommand : ICommand
{
    private readonly Light _light;

    public LightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.OnOff();
    }
}