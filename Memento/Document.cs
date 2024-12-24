namespace Memento;

public class Document
{
    private string _value;

    public Document(string value)
    {
        _value = value;
    }

    public void SetMemento(IMemento memento)
    {
        if (memento is DocumentMemento documentMemento)
        {
            _value = documentMemento.GetState();
        }
        else
        {
            throw new ArgumentException("Invalid memento type");
        }
    }

    public IMemento CreateMemento()
    {
        return new DocumentMemento(_value);
    }
    
    public string GetValue()
    {
        return _value;
    }
}