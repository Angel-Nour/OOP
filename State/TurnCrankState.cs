namespace State;

public class TurnCrankState : IState
{
    public IState InsertCoin()
    {
        Console.WriteLine("Подождите, идет выдача жвачки.");
        return this;
    }

    public IState EjectCoin()
    {
        Console.WriteLine("Вы уже повернули рычаг, монетка не может быть возвращена.");
        return this;
    }

    public IState TurnCrank()
    {
        Console.WriteLine("Вы повернули рычаг, ожидайте...");
        return new DispenseState();
    }

    public IState Dispense()
    {
        Console.WriteLine("Сначала поверните рычаг.");
        return this;
    }
}