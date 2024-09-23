namespace Builder;

public class DeSuaderoTacoDirector
{
    private ITacoBuilder _builder;

    public DeSuaderoTacoDirector(ITacoBuilder builder)
    {
        _builder = builder;
    }

    public string Construct()
    {
        var taco = _builder.AddMeet().AddTortilla().AddOnion().AddSauce().AddTomato().AddCheese().GetTaco();
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