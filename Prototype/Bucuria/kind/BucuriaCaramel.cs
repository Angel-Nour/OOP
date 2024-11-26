namespace AbstractFactory;

public class BucuriaCaramel : ICaramel
{
    public string Try()
    {
        return "Bucuria Caramel";
    }

    public ICaramel Clone()
    {
        return new BucuriaCaramel();
    }
}