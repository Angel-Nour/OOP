namespace Command.cinema.projector;

public class ProjectorOnCommand : ICommand
{
    private readonly Projector _projector;

    public ProjectorOnCommand(Projector projector)
    {
        _projector = projector;
    }

    public void Execute()
    {
        _projector.On();
    }

    public void Undo()
    {
        _projector.Off();
    }
}