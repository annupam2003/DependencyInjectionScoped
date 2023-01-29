namespace DepandeancyInjectionServies;

public class MyService
{
    public IProvider transientProvider { get; }
    public IProvider scopedProvider { get; }
    public IProvider singletopProvider { get; }
    public MyService()
    {
        transientProvider=new TransientProvider();
        scopedProvider = new ScopedProvider();
        singletopProvider = new SingletonProvider();
    }
}