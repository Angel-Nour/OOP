namespace Adapter;

public class Midgets
{
    public void Travel(IFrog transport)
    {
        transport.Jump();
    }
}