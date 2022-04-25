namespace NET6Sandbox;

public class DeconstructorDemo
{
    public static void Demo()
    {
        IDictionary<string, string> MyData = new Dictionary<string, string>()
        {
            ["mykey"] = "1",
            ["data"] = "2"
        };

        foreach ((string key, string val) in MyData)
        {
            Console.WriteLine($"key - {key}, value  - {val}");
        }    
    }
    
}