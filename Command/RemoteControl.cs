namespace Command;

public class RemoteControl
{
    private readonly List<ICommand> _onCommands;
    private readonly List<ICommand> _offCommands;
    private ICommand _lastCommand;

    public RemoteControl()
    {
        _onCommands = new List<ICommand>();
        _offCommands = new List<ICommand>();
        _lastCommand = null!;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        while (_onCommands.Count <= slot)
        {
            _onCommands.Add(null!);
            _offCommands.Add(null!);
        }

        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonPressed(int slot)
    {
        if (slot < _onCommands.Count)
        {
            _onCommands[slot].Execute();
            _lastCommand = _onCommands[slot];
        }
        else
        {
            Console.WriteLine($"Нет команды для кнопки включения {slot}");
        }
    }

    public void OffButtonPressed(int slot)
    {
        if (slot < _offCommands.Count)
        {
            _offCommands[slot].Execute();
            _lastCommand = _offCommands[slot];
        }
        else
        {
            Console.WriteLine($"Нет команды для кнопки выключения {slot}");
        }
    }

    public void UndoButtonPressed()
    {
        _lastCommand.Undo();
    }
}