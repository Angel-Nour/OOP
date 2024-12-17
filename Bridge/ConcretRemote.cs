namespace Bridge;

public class ConcretRemote : Remote
{
    private int _channel = 1;
    public ConcretRemote(ITV tv) : base(tv)
    {
    }

    public override void Set(int channel)
    {
        if (_channel < channel)
        {
            while (_channel != channel)
            {
                this.Next();
            }
        }
        else
        {
            while (_channel != channel)
            {
                this.Previouse();
            }
        }
    }
    
    public void Next()
    {
        _tv.Set(_channel++);
    }

    public void Previouse()
    {
        _tv.Set(_channel--);
    }
}