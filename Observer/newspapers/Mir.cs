namespace Observer.newspapers;

public class Mir : ISubject
{
    private readonly List<IObserver> _observers = new();

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine("Пользователь подписан на газету \"Мир\".");
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Пользователь отписан от газеты \"Мир\".");
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