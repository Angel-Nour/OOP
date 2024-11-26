namespace AbstractFactory;

public class BucuriaChocolate : IChocolate
{
    public string Try()
    {
        return "Bucuria Chocolate";
    }

    public IChocolate Clone()
    {
        return new BucuriaChocolate();
    }
}