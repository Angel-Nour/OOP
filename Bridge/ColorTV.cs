namespace Bridge;

public class ColorTV : ITV
{ 
    public string OnOff(bool status)
    {
        if (status)
        {
            return "Включили цветной телевизор";
        }
        else
        {
            return "Выключили цветной телевизор";
        }
    } 
    
    public string Set(int channel)
    {
        return $"Переключаем цветной телевизор на {channel} канал";
    }
}