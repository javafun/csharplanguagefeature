namespace NET6Sandbox;

public class AsyncStreamDemo
{
    public static async Task Demo()
    {
        var producer = new Producer();
        // var numbers = await producer.GetNumberAsync();
        // foreach (var number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        await foreach (var number in producer.EnumerateNumbersAsync())
        {
            Console.WriteLine(number);
        }
    }
}


public class Producer
{
    public async Task<IEnumerable<int>> GetNumberAsync()
    {
        List<int> numbers = new();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Get some numbers");

            for (int j = 0; j < 10; j++)
            {
                numbers.Add(i*10 + j);
            }

            Console.Write("Making next request...");

            await Task.Delay(2000);
        }

        return numbers;
    }
    
    public async IAsyncEnumerable<int> EnumerateNumbersAsync()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Get some numbers");

            for (int j = 0; j < 10; j++)
            {
                yield return i * 10 + j;
            }

            Console.WriteLine("Making next request...");
            await Task.Delay(2000);
        }
    }
}