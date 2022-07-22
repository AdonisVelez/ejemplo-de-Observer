public class Unsubcripcion : IDisposable
{
    private readonly List<IObserver<Aplicacion>> observers;
    private readonly IObserver<Aplicacion> observer;

    public Unsubcripcion (List<IObserver<Aplicacion>> observers, IObserver<Aplicacion> observer)
    {
        this.observers = observers;
        this.observer = observer;
    }
    public void Dispose()
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

}