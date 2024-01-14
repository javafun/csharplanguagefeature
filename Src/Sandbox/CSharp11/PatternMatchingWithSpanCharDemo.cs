namespace Sandbox.CSharp11;

internal class PatternMatchingWithSpanCharDemo
{
    public static void Demo()
    {
        var readonlySpan = "Keep it simple!".AsSpan();

        if (readonlySpan is "Keep it simple!")
        {
            Console.WriteLine("Simplicity!");
        }

        Span<char> spanChar = new Span<char>(['a', 'b', 'c']);

        if (spanChar is "abc")
        {
            Console.WriteLine("Alphabets");
        }
    }
}
