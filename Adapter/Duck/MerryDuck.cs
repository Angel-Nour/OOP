namespace Adapter;

public class MerryDuck : IDuck
{
    public string Swim()
    {
        return "Уточка плывет в озере";
    }

    public string Quack()
    {
        return "Уточка поет";
    }
}