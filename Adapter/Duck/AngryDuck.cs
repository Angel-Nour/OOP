namespace Adapter;

public class AngryDuck : IDuck
{
    public string Swim()
    {
        return "Утка плывет в озере";
    }

    public string Pluck()
    {
        return "Утка всех щипает";
    }
}