using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.CSharp8
{
    public class IndexFeature
    {
        /*
         * 
         * C# has no way of indexing a collection from the end, but rather most indexers use the "from start" notion, or do a "length - i" expression. 
         * We introduce a new Index expression that means "from the end". The feature will introduce a new unary prefix "hat" operator.
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges
         * */
        public static void Demo()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            var thirdItem = array[2];    // array[2]
            var lastItem = array[^1];    // array[new Index(1, fromEnd: true)]

            Console.WriteLine($"Array [1,2,3,4,5] \r\nThird item array[2] - {thirdItem } \r\nLast item array[^1] - {lastItem}");
        }
    }
}
