namespace DepandeancyInjectionServies;

public class Program
{
    public static void Main(string[] args)
    {
        MyService service1 = new MyService();
        MyService service2 = new MyService();

        ISampleService sampleService1a = service1.scopedProvider.GetSample();
        ISampleService sampleService1b = service1.scopedProvider.GetSample();
        ISampleService sampleService2a = service2.scopedProvider.GetSample();
        ISampleService sampleService2b = service2.scopedProvider.GetSample();
        
        Console.WriteLine(sampleService1a.Id);
        Console.WriteLine(sampleService1b.Id);
        Console.WriteLine(sampleService2a.Id);
        Console.WriteLine(sampleService2b.Id);

    }
}
