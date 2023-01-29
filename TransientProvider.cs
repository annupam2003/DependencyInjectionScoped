namespace DepandeancyInjectionServies;

public class TransientProvider : IProvider
{
    public SampleService GetSample()
    {
        return new SampleService();
    }
}
