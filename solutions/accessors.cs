namespace Solutions {
  // Объявление класса может содержать модификатор доступа. По умолчанию - internal.
  public class Modificators
  {
    // Приватное свойство. Доступ есть только у самого класса.
    // Объявлять не обязательно. По умолчанию private.
    private int _count;
    // Только для чтения
    readonly int readOnlyProp = 1;

    // Метод может быть вызван в теле класса и в дочерних классах.
    protected string Method1() {
      return "result from protected method";
    }

    public int GetNextValue() { // Метод может быть вызван извне.
       _count += 1;
      return _count;
    }

    public class MySubClass : Modificators
    {
      public string Method2()
      {
        return Method1();
      }
    }
  }
}