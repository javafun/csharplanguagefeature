namespace Sandbox.CSharp11;

/// <summary>
///  In C# 11 this definition is extended to allow nameof operator to specify the name of a method parameter in an
///  attribute on the method or parameter declaration
/// </summary>
internal class NameOfExtendDemo
{
    [CustomerNameNullCheck(nameof(values))]
    public static void Demo(List<int> values)
    {
        Console.WriteLine(nameof(values));
        Console.WriteLine(nameof(values.Count));
        
        
        [CustomerNameNullCheck(nameof(T))]
        void LocalFunction<T>(T param){}
    
    
        var lambdaExpression = ([CustomerNameNullCheck(nameof(someNumber))] int someNumber) => someNumber.ToString(); //C# 11
    }
    

}

public class CustomerNameNullCheck : Attribute
{
    private readonly string _paraName;

    public CustomerNameNullCheck(string paraName)
    {
        _paraName = paraName;
    }
}