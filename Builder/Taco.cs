using System.Text;

namespace Builder;

public class Taco
{
    public List<string> Ingredients { get; set; }
    public Taco(List<string> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        var text = new StringBuilder();
        text.Append("Burger: ");
        text.Append("Ingredients: ");
        text.AppendJoin(", ", Ingredients);
        
        return text.ToString();
    }
    
    public object Clone()
    {
        return new Taco(new List<string>(this.Ingredients));
    }
}