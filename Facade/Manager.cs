namespace Facade;

public class Manager
{
    protected Design _designer;
    protected Frontend _frontender;
    protected Backend _backender;
    
    public Manager(Design designer, Frontend frontender, Backend backender)
    {
        _designer = designer;
        _frontender = frontender;
        _backender = backender;
    }

    public string AddButton()
    { 
       return _designer.Draw() + _backender.Develop() + _frontender.Develop();
    }

    public string FixUI()
    {
       return _frontender.Fix() + _backender.Fix();
    }

    public string FixCalculations()
    {
       return _backender.Fix();
    }
}