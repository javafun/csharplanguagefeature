namespace Sandbox.CSharp11;

/// <summary>
/// C# 11 introduces a new access modifier file.
/// The visibility of created type is scoped to
/// the source file in which it is declared.
/// This feature helps source generator
/// authors avoid naming collisions
/// </summary>
internal class FileScopedTypeDemo
{
    public static void Demo()
    {
        //Animal a = new Animal();
    }
}


