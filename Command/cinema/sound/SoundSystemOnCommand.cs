namespace Command.cinema.sound;

public class SoundSystemOnCommand : ICommand
{
    private readonly SoundSystem _soundSystem;

    public SoundSystemOnCommand(SoundSystem soundSystem)
    {
        _soundSystem = soundSystem;
    }

    public void Execute()
    {
        _soundSystem.On();
    }

    public void Undo()
    {
        _soundSystem.Off();
    }
}