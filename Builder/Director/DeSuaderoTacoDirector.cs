namespace Builder;

public class DeSuaderoTacoDirector
{
    private ITacoBuilder _builder;

    public DeSuaderoTacoDirector(ITacoBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.AddMeet();
        _builder.AddTortilla();
        _builder.AddOnion();
        _builder.AddSauce();
        _builder.AddTomato();
        _builder.AddCheese();
    }
}