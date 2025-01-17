namespace Command.kettle;

public class KettleOffCommand: ICommand
{
    private readonly Kettle _kettle;

    public KettleOffCommand(Kettle kettle)
    {
        _kettle = kettle;
    }

    public void Execute()
    {
        _kettle.Off();
    }
}