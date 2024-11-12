namespace Bridge;

public class OldTV : ITV
{
    public string OnOff(bool f)
    {
        if (f)
            return "Включили старый телевизор";
        else
            return "Выключили старый телевизор";
    }

    public string Set(int c)
    {
        return $"Переключаем старый телевизор на {c} канал";
    }

    public int GetChannel()
    {
        return 5;
    }
}