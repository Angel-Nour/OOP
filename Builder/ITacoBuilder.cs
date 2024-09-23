namespace Builder;

public interface ITacoBuilder
{
    ITacoBuilder AddTortilla();
    ITacoBuilder AddMeet();
    ITacoBuilder AddSauce();
    ITacoBuilder AddSalad();
    ITacoBuilder AddCheese();
    ITacoBuilder AddTomato();
    ITacoBuilder AddBeans();
    ITacoBuilder AddOnion();
    ITacoBuilder AddPepper();
    ITacoBuilder AddAvocado();
    Taco GetTaco();
}