namespace NET6Sandbox;

public class InKeywordDemo
{
    public static void Demo()
    {
        var person = new Person("vincent", "yang");
        Print(person);

        var number = 3;
        Print(number);
    }

    /// <summary>
    ///     Add in keyword as example, so the input object can no longer be accidentally changed. 
    /// </summary>
    /// <param name="input"></param>
    static void Print(in object input)
    {
        //input = new Person("tester", "tester2");
        Console.WriteLine(input.ToString());
    }

    record Person(string FirstName, string LastName)
    {
        public override string ToString() => $"{FirstName}-{LastName}";
    }
}