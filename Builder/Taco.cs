using System.Text;

namespace Builder;

public class Taco
{
    private readonly List<string> ingredients;
    public Taco()
    {
        ingredients = new List<string>();
    }

    public override string ToString()
    {
        var text = new StringBuilder();
        text.Append("Burger: ");
        text.Append("Ingredients: ");
        text.AppendJoin(", ", ingredients);
        
        return text.ToString();
    }
    
}