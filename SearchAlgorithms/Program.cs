using System;
using System.Linq;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 5, 6, 8 };

            int index = RotatedArray.FindElement(arr);
                                    
            Console.WriteLine(index);

        }
    }
}
