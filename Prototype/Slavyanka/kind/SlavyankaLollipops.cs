namespace AbstractFactory;

public class SlavyankaLollipops : ILollipops
{
    public string Try()
    {
        return "Slavyanka Lollipops";
    }

    public ILollipops Clone()
    {
        return new SlavyankaLollipops();
    }
}