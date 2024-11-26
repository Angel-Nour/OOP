namespace AbstractFactory;

public class SlavyankaCaramel : ICaramel
{
    public string Try()
    {
        return "Slavyanka Caramel";
    }

    public ICaramel Clone()
    {
        return new SlavyankaCaramel();
    }
}