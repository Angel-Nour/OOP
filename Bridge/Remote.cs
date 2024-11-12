namespace Bridge;

public abstract class Remote
{
    protected ITV _tv;

    public ITV _Tv
    {
        set { _tv = value; }
    }

    public Remote(ITV tv)
    {
        _tv = tv;
    }

    public virtual void On()
    {
        _tv.OnOff(true);
    }

    public virtual void Off()
    {
        _tv.OnOff(false);
    }

    public virtual void Set()
    {
        _tv.Set(_tv.GetChannel());
    }
}