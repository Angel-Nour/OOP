namespace Command.cinema.recliner;

public class ReclinerSittingCommand: ICommand
{
    private readonly Recliner _recliner;

    public ReclinerSittingCommand(Recliner recliner)
    {
        _recliner = recliner;
    }

    public void Execute()
    {
        _recliner.ToSittingPosition();
    }
}