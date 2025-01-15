namespace Command.cinema.projector;

public class ProjectorOffCommand : ICommand
{
    private readonly Projector _projector;

    public ProjectorOffCommand(Projector projector)
    {
        _projector = projector;
    }

    public void Execute()
    {
        _projector.Off();
    }

    public void Undo()
    {
        _projector.On();
    }
}