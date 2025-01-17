namespace Observer.newspapers;

public class Novosti : ISubject
{
    private event Action<string> OnNewspaperAvailable;

    public void Subscribe(IObserver observer)
    {
        OnNewspaperAvailable += observer.Update;
        Console.WriteLine("Пользователь подписан на газету \"Новости\".");
    }

    public void Unsubscribe(IObserver observer)
    {
        OnNewspaperAvailable -= observer.Update;
        Console.WriteLine("Пользователь отписан от газеты \"Новости\".");
    }

    public void Notify(string newspaperName)
    {
        Console.WriteLine($"Газета \"{newspaperName}\" появилась в продаже.");
        OnNewspaperAvailable?.Invoke(newspaperName);
    }
}