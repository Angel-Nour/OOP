namespace AbstractFactory;

public class RoshenLollipops : ILollipops
{
    public string Try()
    {
        return "Roshen Lollipops";
    }

    public ILollipops Clone()
    {
        return new RoshenLollipops();
    }
}