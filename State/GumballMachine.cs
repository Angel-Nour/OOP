namespace State;

public class GumballMachine
{
    private IState _state;

    public GumballMachine()
    {
        _state = new InsertCoinState();
    }

    public void InsertCoin()
    {
        _state = _state.InsertCoin();
    }

    public void EjectCoin()
    {
        _state = _state.EjectCoin();
    }
    
    public void TurnCrank()
    {
        _state = _state.TurnCrank();
    }
    
    public void Dispense()
    {
        _state = _state.Dispense();
    }
}