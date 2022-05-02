using Singleton;

SingletonObject.Instance = new SingletonObject();
var object1 = SingletonObject.Instance;

SingletonObject.Instance = new SingletonObject();
var object2 = SingletonObject.Instance;

Console.WriteLine(
    object1 == object2
    ? "object1 и object2 содержат ссылки на одну и ту же сущность объекта-одиночки"
    : "object1 и object2 содержат ссылки на разные сущности объекта-одиночки"
);
//Выводит: object1 и object2 содержат ссылки на одну и ту же сущность объекта-одиночки