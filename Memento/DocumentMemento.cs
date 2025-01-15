namespace Memento;

public class DocumentMemento : IMemento
{
    private readonly string _state;
    private readonly DateTime _date;

    public DocumentMemento(string state)
    {
        _state = state;
        _date = DateTime.UtcNow;
    }
    public string GetState()
    {
        return _state;
    }

    public string GetDate()
    {
        return _date.ToShortDateString();
    }
}