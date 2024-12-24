namespace Strategy;

public class NoFly : IFly
{
    public string Fly()
    {
        return "уточка не может полетать";
    }
}