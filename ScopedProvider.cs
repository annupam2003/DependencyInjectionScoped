namespace DepandeancyInjectionServies;

public class ScopedProvider : IProvider
{
    private SampleService sample = null;
    public SampleService GetSample()
    {
        if (sample == null)
            sample = new SampleService();
        return sample;
    }
}
