using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 4,2,6,9,13,1};

            //Length Method
            Console.WriteLine("Length of array is: "+ numbers.Length);

            //IndexOf()
            var index= Array.IndexOf(numbers, 13);
            Console.WriteLine("Index of 13: " +index);

            //Clear()
            Array.Clear(numbers, 3, 2);
            Console.WriteLine("Effect of clear():");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Copy()
            var another = new int[4];
            Array.Copy(numbers, another, 4);

            Console.WriteLine("Effect of copy():");
            foreach (var n in another)
                Console.WriteLine(n);


            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of sort():");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse():");
            foreach(var n in numbers)
                Console.WriteLine(n);

            Console.ReadLine(); 
        }
    }
}
