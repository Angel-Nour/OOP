using System.Text;

namespace Builder;

public class Taco
{
    private readonly List<string> _ingredients;
    public Taco(List<string> ingredients)
    {
        _ingredients = ingredients;
    }

    public override string ToString()
    {
        var text = new StringBuilder();
        text.Append("Burger: ");
        text.Append("Ingredients: ");
        text.AppendJoin(", ", _ingredients);
        
        return text.ToString();
    }
    
}