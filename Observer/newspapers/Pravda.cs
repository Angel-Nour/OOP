namespace Observer.newspapers;

public class Pravda : ISubject
{
    private readonly List<IObserver> _observers = new();

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine("Пользователь подписан на газету \"Правда\".");
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Пользователь отписан от газеты \"Правда\".");
    }

    public void Notify(string newspaperName)
    {
        Console.WriteLine($"Газета \"{newspaperName}\" появилась в продаже.");
        foreach (var observer in _observers)
        {
            observer.Update(newspaperName);
        }
    }
}