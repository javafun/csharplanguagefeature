namespace Sandbox;

internal class GenericAttributesBeforeCsharp11Demo
{
    [CustomType(typeof(string))]
    public string? Method()=>default;
}

public class CustomTypeAttribute : Attribute
{
    public CustomTypeAttribute(Type t) => ParamType = t;
    
    public Type ParamType{get;}
}

internal class GenericAttributes
{
    [Generic<string>()]
    public string Method()=>default;
}

public class GenericAttribute<T>:Attribute{}