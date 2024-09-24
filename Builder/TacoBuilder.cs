namespace Builder;

public class TacoBuilder : ITacoBuilder
{
    private static TacoBuilder? _instance;
    private Taco _taco = new Taco();

    private TacoBuilder() { }
    
    public static TacoBuilder GetInstance()
    {
        if (_instance == null)
        {
            _instance = new TacoBuilder();
        }
        return _instance;
    }
    public ITacoBuilder AddTortilla()
    {
        _taco.ingredients.Add("Tortilla");
        return this;
    }

    public ITacoBuilder AddMeet()
    {
        _taco.ingredients.Add("Meet");
        return this;
    }

    public ITacoBuilder AddSauce()
    {
        _taco.ingredients.Add("Sauce"); 
        return this;
    }

    public ITacoBuilder AddSalad()
    {
        _taco.ingredients.Add("Salad");
        return this;
    }

    public ITacoBuilder AddCheese()
    { 
        _taco.ingredients.Add("Cheese");
        return this;
    }

    public ITacoBuilder AddTomato()
    {
        _taco.ingredients.Add("Tomato");
        return this;
    }

    public ITacoBuilder AddBeans()
    {
        _taco.ingredients.Add("Beans");
        return this;
    }

    public ITacoBuilder AddOnion()
    {
        _taco.ingredients.Add("Onion");  
        return this;
    }

    public ITacoBuilder AddPepper()
    {
        _taco.ingredients.Add("Pepper"); 
        return this;
    }

    public ITacoBuilder AddAvocado()
    {
        _taco.ingredients.Add("Avocado");
        return this;
    }

    public Taco? GetTaco()
    {
        if (_taco.ingredients.Contains("Tortilla"))
        {
            return _taco;
        }
        else
        {
            return null;
        }
    }
    
    public Taco CloneTaco()
    {
        return (Taco)_taco.Clone();
    }
    
    public void Reset()
    {
        _taco = new Taco();
    }
}