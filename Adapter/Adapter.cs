namespace Adapter;

public class Adapter : IFrog
{
    private readonly IDuck _duck;

    public Adapter(IDuck d)
    {
        _duck = d;
    }

    public string Jump()
    {
       return _duck.Swim();
    }
}