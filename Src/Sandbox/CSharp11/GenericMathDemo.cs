using System.Numerics;

namespace Sandbox;

internal class GenericMathDemo
{
    public static void Demo()
    {
        Console.WriteLine("Generic Math Demo");


        Vector v1 = new() { X = -2, Y = 8 };
        Vector v2 = new() { X = 6, Y = -1 };

        Console.WriteLine(v1+v2);
        Console.WriteLine(v1-v2);

        // Example 2

        Console.WriteLine(new List<int>{5,-3,0,25}.AddNumbers<int,long>());

        
        Console.WriteLine(new List<double> { 5.5, 3.2, 4.6, 10.7 }.AddNumbers<double, double>()); //Outputs: 24
    }
}


public record Vector: IAdditionOperators<Vector,Vector,Vector>,
ISubtractionOperators<Vector,Vector,Vector>{
    public int X{get;set;}
    public int Y { get; set; }

    public static Vector operator +(Vector self, Vector other){
        return new Vector{ X = self.X + other.X, Y = self.Y + other.Y};
    }

    public static Vector operator -(Vector self, Vector other){
        return new Vector{ X = self.X - other.X, Y = self.Y - other.Y};
    }
}

internal static class MathExtensions{
    public static TResult AddNumbers<T,TResult>(this IEnumerable<T> values)
    where T: INumber<T>
    where TResult : INumber<TResult>{
        TResult result = TResult.Zero;

        foreach(var v in values){
            result += TResult.CreateChecked(v);
        }

        return result;
    }
}