namespace Builder;

public class Taco
{
    public List<string> ingredients = new List<string>();
    
    public override string ToString()
    {
        return $"Taco with: {string.Join(", ", ingredients)}";
    }
    
    public object Clone()
    {
        Taco clone = new Taco();
        clone.ingredients = new List<string>(this.ingredients);
        return clone;
    }

  /*  public string Menu()
    {
        List<string> AllIngredients = new List<string>();
        
        AllIngredients.Add("Tortilla"); 
        AllIngredients.Add("Meet"); 
        AllIngredients.Add("Sauce");
        AllIngredients.Add("Salad");
        AllIngredients.Add("Cheese");
        AllIngredients.Add("Tomato");
        AllIngredients.Add("Beans");
        AllIngredients.Add("Onion");
        AllIngredients.Add("Pepper");
        AllIngredients.Add("Avocado");
        
        return $"Products: :{string.Join(", ", AllIngredients)}";
    }*/
}