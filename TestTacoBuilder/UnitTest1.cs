using Builder;

namespace TestTacoBuilder;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        TacoBuilder builder = TacoBuilder.GetInstance();
        OwnTacoDirector director = new OwnTacoDirector(builder);

        List<string> selectedIngredients = new List<string> {"cheese", "tortilla"};
        var result = director.Construct(selectedIngredients);
        
        Taco clonedTaco = builder.CloneTaco();
        clonedTaco.ingredients.Add("Avocado");
        
        TestContext.WriteLine(clonedTaco);
        builder.Reset(); 
    }
}