namespace Command.kettle;

public class KettleOnCommand: ICommand
{
    private readonly Kettle _kettle;

    public KettleOnCommand(Kettle kettle)
    {
        _kettle = kettle;
    }

    public void Execute()
    {
        _kettle.On();
    }
}