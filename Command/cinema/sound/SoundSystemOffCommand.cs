namespace Command.cinema.sound;

public class SoundSystemOffCommand : ICommand
{
    private readonly SoundSystem _soundSystem;

    public SoundSystemOffCommand(SoundSystem soundSystem)
    {
        _soundSystem = soundSystem;
    }

    public void Execute()
    {
        _soundSystem.Off();
    }
}