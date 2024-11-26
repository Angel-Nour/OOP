namespace AbstractFactory;

public class SlavyankaChocolate : IChocolate
{
    public string Try()
    {
        return "Slavyanka Chocolate";
    }

    public IChocolate Clone()
    {
        return new SlavyankaChocolate();
    }
}