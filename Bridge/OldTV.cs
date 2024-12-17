namespace Bridge;

public class OldTV : ITV
{
    public string OnOff(bool status)
    {
        if (status)
            return "Включили старый телевизор";
        else
            return "Выключили старый телевизор";
    }

    public string Set(int channel)
    {
        return $"Переключаем старый телевизор на {channel} канал";
    }
}