namespace Builder;

public class VegetableTacoDirector
{
    private ITacoBuilder _builder;

    public VegetableTacoDirector(ITacoBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.AddTortilla();
        _builder.AddSauce(); 
        _builder.AddTomato(); 
        _builder.AddAvocado();
        _builder.AddSalad();
        _builder.AddPepper();

    }
}