namespace DepandeancyInjectionServies;

public class SampleService : ISampleService
{
    public Guid Id { get; private set; }
    public SampleService()
    {
        Id= Guid.NewGuid();
    }
}
