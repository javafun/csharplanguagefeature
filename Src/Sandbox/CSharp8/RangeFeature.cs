using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sandbox.CSharp8
{
    public class RangeFeature
    {
        /*
         * The language will introduce a new range operator x..y. It is a binary infix operator that accepts two expressions
         * . Either operand can be omitted (examples below), and they have to be convertible to System.Index. It will be lowered to the appropriate System.Range factory method call.
         * 
         * */
        public static void Demo()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            var slice1 = array[2..^3];    // array[new Range(2, new Index(3, fromEnd: true))]
            var slice2 = array[..^3];     // array[Range.EndAt(new Index(3, fromEnd: true))]
            var slice3 = array[2..];      // array[Range.StartAt(2)]
            var slice4 = array[..];       // array[Range.All]

            Console.WriteLine($"Array [1,2,3,4,5] \r\n" +
                $"array[2..^3] - {ConverArrayToStringWithComma(slice1)}\r\n" +
                $"array[..^3] - {ConverArrayToStringWithComma(slice2)}\r\n" +
                $"array[2..] - {ConverArrayToStringWithComma(slice3)}\r\n" +
                $"array[..] - {ConverArrayToStringWithComma(slice4)}");

            
        }

        static string ConverArrayToStringWithComma<T>(T[] input)
        {
            return string.Join(',', input);
        }
    }
}
