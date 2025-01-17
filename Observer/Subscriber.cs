namespace Observer;

public class Subscriber : IObserver
{
    private readonly string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    public void Update(string newspaperName)
    {
        Console.WriteLine($"{_name} уведомлен: я иду на почту за газетой \"{newspaperName}\".");
    }
}