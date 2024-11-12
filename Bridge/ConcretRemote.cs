namespace Bridge;

public class ConcretRemote : Remote
{
    public ConcretRemote(ITV tv) : base(tv)
    {
    }

    public void Next()
    {
        _tv.Set(_tv.GetChannel() + 1);
    }

    public void Previouse()
    {
        _tv.Set(_tv.GetChannel() - 1);
    }
}