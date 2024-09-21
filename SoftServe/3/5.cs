using System;

public class EventProgram
{
    // Определение события Show типа EventHandler
    public event EventHandler Show;

    // Конструктор, где добавляются обработчики и вызывается событие
    public EventProgram()
    {
        // Добавление методов в список вызовов события Show
        Show += Dog;
        Show += Cat;
        Show += Mouse;
        Show += Elephant;

        // Вызов события
        OnShow(EventArgs.Empty);
    }

    // Метод для вызова события
    protected virtual void OnShow(EventArgs e)
    {
        if (Show != null)
        {
            Show(this, e);
        }
    }

    // Статические методы, которые выводят названия животных
    public static void Dog(object sender, EventArgs e)
    {
        Console.WriteLine("Dog");
    }

    public static void Cat(object sender, EventArgs e)
    {
        Console.WriteLine("Cat");
    }

    public static void Mouse(object sender, EventArgs e)
    {
        Console.WriteLine("Mouse");
    }

    public static void Elephant(object sender, EventArgs e)
    {
        Console.WriteLine("Elephant");
    }
}

//class Program
//{
//    static void Main()
//    {
//        // Создание экземпляра EventProgram, что автоматически вызывает событие
//        EventProgram eventProgram = new EventProgram();
//    }
//}
