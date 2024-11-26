namespace AbstractFactory;

public class RoshenCaramel : ICaramel
{
    public string Try()
    {
        return "Roshen Caramel";
    }

    public ICaramel Clone()
    {
        return new RoshenCaramel();
    }
}