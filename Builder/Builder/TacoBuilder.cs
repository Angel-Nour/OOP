namespace Builder;

public class TacoBuilder : ITacoBuilder
{
    private List<string> _ingredients;
    
    public TacoBuilder()
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
    
    public Taco GetTaco()
    {
        return new Taco();
    }
    
    public void Reset()
    {
        _ingredients = new List<string>();
    }
}