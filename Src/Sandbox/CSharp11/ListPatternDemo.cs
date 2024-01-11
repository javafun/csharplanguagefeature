using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Sandbox;

internal class ListPatternDemo
{
    public static void Demo(){
        var numbers = new[] {-10, 0, 5,7};

        Console.WriteLine(numbers is [-10,0,5,7]); // true
        Console.WriteLine(numbers is [-10,0,5]); // false
        Console.WriteLine(numbers is [7,-10,0,5]); // false
        
        // Comparison with discard patterns
        Console.WriteLine(numbers is [_,0,_,7]); // true 

        // Comparison with range patterns
        Console.WriteLine(numbers is [..,5,_]); // true

        // Comparison with logical patterns
        Console.WriteLine(numbers is [_,<=2,_,_]); // true

        // Comparison with length patterns
        if(numbers is [<0,..{Length: 2 or 4},>0]) // true
        {
            Console.WriteLine("valid");
        }
        else
        {
            System.Console.WriteLine("invalid");
        }

        // Comparison with var pattern

        if("Curious" is ['c' or 'C', 'u',..var str,'u','s' or 'S'] ) // true
        {
            System.Console.WriteLine(str);
            System.Console.WriteLine("matched");
        }
        else
        {
            System.Console.WriteLine("not matched");

        }
    }
}
