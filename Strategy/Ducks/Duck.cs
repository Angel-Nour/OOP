namespace Strategy.Ducks;

public abstract class Duck
{
    private IFly _fly;
    private ISwim _swim;
    private ICrack _crack;

    protected Duck(IFly fly, ISwim swim, ICrack crack)
    {
        _fly = fly == null ? throw new ArgumentNullException(nameof(fly)) : fly;
        _crack = crack == null ? throw new ArgumentNullException(nameof(crack)) : crack;
        _swim = swim == null ? throw new ArgumentNullException(nameof(swim)) : swim;
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