namespace Builder;

public class MenuTacoBuilder : ITacoBuilder
{
    private List<string> _ingredients;
    
    public MenuTacoBuilder()
    {
        _ingredients = new List<string>();
    }
    
    public void AddTortilla()
    {
        _ingredients.Add("Tortilla");
    }

    public void AddMeet()
    {
        _ingredients.Add("Meet");
    }

    public void AddSauce()
    {
        _ingredients.Add("Sauce");
    }

    public void AddSalad()
    {
        _ingredients.Add("Salad");
    }

    public void AddCheese()
    { 
        _ingredients.Add("Cheese");
    }

    public void AddTomato()
    {
        _ingredients.Add("Tomato");
    }

    public void AddBeans()
    {
        _ingredients.Add("Beans");
    }

    public void AddOnion()
    {
        _ingredients.Add("Onion");  
    }

    public void AddPepper()
    {
        _ingredients.Add("Pepper");
    }

    public void AddAvocado()
    {
        _ingredients.Add("Avocado");
    }
    
    public string GetTaco()
    {
        return string.Join(" ", _ingredients);
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