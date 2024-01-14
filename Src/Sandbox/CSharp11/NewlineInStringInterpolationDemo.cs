namespace Sandbox.CSharp11;

internal class NewlineInStringInterpolationDemo
{
    public static void Demo()
    {
        // Example 1 - switch expression
        int statusCode = 302;
        string message = $"Http status code {statusCode} is for {statusCode switch
        {
            > 599 or < 100 => "Invalid",
            > 499 => "Server error",
            > 399 => "Client error",
            > 299 => "Redirection",
            > 199 => "Successful",
            > 99 => "Informational response"

        }}";

        Console.WriteLine(message);

        // Example 2 - Linq query

        int[] numbers = [1,2,3,4,5,6,7,8,9,10];

        Console.WriteLine($"The even values of {nameof(numbers)} are {string.Join(", ",numbers.Where(n=>n%2 == 0))}.");
    }
}