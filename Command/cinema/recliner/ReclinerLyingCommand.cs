namespace Command.cinema.recliner;

public class ReclinerLyingCommand: ICommand
{
    private readonly Recliner _recliner;

    public ReclinerLyingCommand(Recliner recliner)
    {
        _recliner = recliner;
    }

    public void Execute()
    {
        _recliner.ToLyingPosition();
    }
}