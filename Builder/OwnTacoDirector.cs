namespace Builder;

public class OwnTacoDirector
{
    private ITacoBuilder _builder;

    public OwnTacoDirector(ITacoBuilder builder)
    {
        _builder = builder;
    }

    public string Construct(List<string> selectedIngredients)
    {
        foreach (var ingredient in selectedIngredients)
        {
            switch (ingredient.ToLower())
            {
                case "tortilla":
                    _builder.AddTortilla();
                    break;
                case "meet":
                    _builder.AddMeet();
                    break;
                case "sauce":
                    _builder.AddSauce();
                    break;
                case "avocado":
                    _builder.AddAvocado();
                    break;
                case "beans":
                    _builder.AddBeans();
                    break;
                case "cheese":
                    _builder.AddCheese();
                    break;
                case "onion":
                    _builder.AddOnion();
                    break;
                case "tomato":
                    _builder.AddTomato();
                    break;
                case "pepper":
                    _builder.AddPepper();
                    break;
                case "salad":
                    _builder.AddSalad();
                    break;
                default:
                    throw new Exception();
            }
        }

        var taco = _builder.GetTaco();
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