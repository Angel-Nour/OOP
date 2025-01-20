namespace Command;

public class RemoteControl
{
    private readonly List<(ICommand OnCommand, ICommand OffCommand)> _commands = new();
    private readonly Stack<ICommand> _history = new();

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        if (slot >= _commands.Count)
        {
            _commands.Add((onCommand, offCommand));
        }
        else
        {
            _commands[slot] = (onCommand, offCommand);
        }
    }

    public void OnButtonPressed(int slot)
    {
        if (slot < _commands.Count)
        {
            _commands[slot].OnCommand.Execute();
            _history.Push(_commands[slot].OffCommand);
        }
    }

    public void OffButtonPressed(int slot)
    {
        if (slot < _commands.Count)
        {
            _commands[slot].OffCommand.Execute();
            _history.Push(_commands[slot].OnCommand);
        }
    }

    public void UndoButtonPressed()
    {
        if (_history.Count > 0)
        {
            var lastCommand = _history.Pop();
            lastCommand.Execute();
        }
        else
        {
            Console.WriteLine("Нет действий для отмены.");
        }
    }
}