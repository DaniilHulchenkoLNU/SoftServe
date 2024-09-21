public abstract class CloseableResource
{
    public void Close()
    {
        //Dispose();
    }
}

public class DisposePatternImplementer : CloseableResource, IDisposable
{
    // Для обнаружения повторных вызовов
    private bool disposed = false;

    // Реализация метода Dispose
    public void Dispose()
    {
        // Освобождение управляемых и неуправляемых ресурсов
        Dispose(true);

        // Подавление финализации, так как управляемые ресурсы уже очищены
        GC.SuppressFinalize(this);
    }

    // Защищённый метод для освобождения управляемых и неуправляемых ресурсов
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Освобождение управляемых ресурсов
                Console.WriteLine("Освобождение ресурсов разработчиком");

                // Убедиться, что метод Close() вызывается
                Close();
            }
            else
            {
                // Если не освобождено разработчиком (GC вызывает Dispose)
                Console.WriteLine("Освобождение ресурсов сборщиком мусора");

                // Убедиться, что метод Close() вызывается
                Close();
            }

            // Освободить неуправляемые ресурсы здесь, если они есть

            // Отметить объект как освобождённый
            disposed = true;
        }
    }

    // Деструктор/финализатор (вызывается сборщиком мусора, если Dispose не был вызван)
    ~DisposePatternImplementer()
    {
        Dispose(false);
    }
}








































//public class DisposePatternImplementer : CloseableResource, IDisposable
//{
//    private bool disposed = false;
//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }
//    protected virtual void Dispose(bool disposing)
//    {
//        if (!disposed)
//        {
//            if (disposing)
//            {
//                Console.WriteLine("Disposing by developer");
//                Close();
//            }
//            else
//            {
//                Console.WriteLine("Disposing by GC");
//                Close();
//            }
//            disposed = true;
//        }
//    }
//    ~DisposePatternImplementer()
//    {
//        Dispose(false);
//    }
//}
