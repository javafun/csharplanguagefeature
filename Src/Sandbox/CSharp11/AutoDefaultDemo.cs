namespace Sandbox.CSharp11;
/// <summary>
/// See CS0843 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors?f1url=%3FappId%3Droslyn%26k%3Dk(CS0843)#breaking-changes-on-struct-initialization
/// </summary>
internal struct Point
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x)
    {
        X = x;
    }

    public override string ToString()
    {
        return $"[X = {X}, Y = {Y}]";
    }
}

internal class AutoDefaultStructure{
    public static void Demo(){
        Point p = new(1);
        System.Console.WriteLine(p);
    }
}