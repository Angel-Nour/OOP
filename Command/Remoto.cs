using System.Windows.Input;

namespace Command;

public class Remoto
{
    private (ICommand, ICommand)[] commands;
    private Stack<ICommand> history;

    public Remoto()
    {
       // commands = new (ICommand, ICommand)[] (null, null);
        history = new Stack<ICommand>();
    }
}