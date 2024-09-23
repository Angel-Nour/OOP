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
        TacoBuilder builder = new TacoBuilder();
        OwnTacoDirector director = new OwnTacoDirector(builder);

        List<string> selectedIngredients = new List<string> {"cheese"};
        var result = director.Construct(selectedIngredients);

        TestContext.WriteLine(result);
    }
}