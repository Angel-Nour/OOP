namespace Command.cinema;

public class CollectionCommand : ICommand
{
    private readonly List<ICommand> _commands;

    public CollectionCommand(List<ICommand> commands)
    {
        _commands = commands;
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}