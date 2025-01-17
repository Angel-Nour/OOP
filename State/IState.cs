namespace State;

public interface IState
{
    IState InsertCoin(); 
    IState EjectCoin(); 
    IState TurnCrank(); 
    IState Dispense();  
}