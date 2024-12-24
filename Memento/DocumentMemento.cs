namespace Memento;

public class DocumentMemento : IMemento
{
    private string _state;
    private DateTime _date;

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

    public void SetState(string state)
    {
        _state = state;
    }
}