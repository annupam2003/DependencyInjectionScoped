namespace DepandeancyInjectionServies;

public class SingletonProvider : IProvider
{
    private static SampleService sample = null;
    public SampleService GetSample()
    {
        if(sample == null)
            sample = new SampleService();
        return sample;
    }
}
