namespace Singleton;

public class SingletonObject
{
    private static SingletonObject? _instance;

    public static SingletonObject? Instance
    {
        get
        {
            Console.WriteLine("Возврат объекта-одиночки");
            return _instance;
        }
        set
        {
            Console.WriteLine("Попытка установить значение объекту-одиночке");
            if (_instance is not null)
            {
                Console.WriteLine("Объект-одиночка уже содержит значение; новое значение не было установлено");
                return;
            }
            Console.WriteLine("Объект-одиночка не содержит значения; новое значение установлено");
            _instance = value;
        }
    }
}