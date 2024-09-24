namespace Builder;

public class VegetableTacoDirector
{
    private ITacoBuilder _builder;

    public VegetableTacoDirector(ITacoBuilder builder)
    {
        _builder = builder;
    }

    public string Construct()
    {
       var taco = _builder.AddTortilla().AddSauce().AddTomato().AddAvocado().AddSalad().AddPepper().GetTaco();
        if (taco == null)
        {
            return "Taco not ready";
        }
        else
        {
            return taco.ToString();
        }
    }
}