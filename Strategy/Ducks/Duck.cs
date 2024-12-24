namespace Strategy.Ducks;

public abstract class Duck
{
    private IFly _fly;
    private ISwim _swim;
    private ICrack _crack;

    protected Duck(IFly fly, ISwim swim, ICrack crack)
    {
        _fly = fly;
        _crack = crack;
        _swim = swim;
    }

    public string DoFly()
    {
        return _fly.Fly();
    }
    
    public string DoSwim()
    {
        return _swim.Swim();
    }
    
    public string DoCrack()
    {
        return _crack.Crack();
    }
    
}