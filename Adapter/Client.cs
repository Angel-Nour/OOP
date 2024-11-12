namespace Adapter;

public class Client
{
    static void Do()
    {
        Midgets _midgets = new Midgets();
        IFrog _frog = new BigFrog();
        _midgets.Travel(_frog);
        IDuck _duck = new MerryDuck();
        IFrog duckToFrog = new Adapter(_duck);
        _midgets.Travel(duckToFrog);

        Console.Read();
    }
}