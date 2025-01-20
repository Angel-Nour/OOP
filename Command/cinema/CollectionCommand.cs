namespace Command.cinema;

public class CollectionCommand : ICommand
{
    private readonly List<(ICommand OnCommand, ICommand OffCommand)> _commands;
    private readonly bool _isOn;

    public CollectionCommand(List<(ICommand OnCommand, ICommand OffCommand)> commands, bool isOn)
    {
        _commands = commands;
        _isOn = isOn;
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            if (_isOn)
            {
                command.OnCommand.Execute();
            }
            else
            {
                command.OffCommand.Execute();
            }
        }
    }
}