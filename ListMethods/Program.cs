using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4,5};
            //Add()
            numbers.Add(1);
            foreach(var number in numbers)
                Console.WriteLine(number);

            //AddRange()
            numbers.AddRange(new int[3] { 6, 7, 8 });
            foreach(var number in numbers)
                Console.WriteLine(number);

            //Indexof()
            Console.WriteLine();
            Console.WriteLine("Index of 1:" + numbers.IndexOf(1));
            Console.WriteLine("Index of 1:" + numbers.LastIndexOf(1));

            //Count
            Console.WriteLine("Count :" + numbers.Count);

            //Remove
            numbers.Remove(1);
            foreach(var number in numbers)
                Console.WriteLine(number);

            //Want to remove all 1 from list(Cant use foreach loop if do, get exception....so using for loop)
            for(var i=0; i< numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
                    
            }
            foreach(var number in numbers)
                Console.WriteLine(number);
            //clear()
            numbers.Clear();
            Console.WriteLine("Count :" + numbers.Count);


            Console.ReadLine(); 
        }
    }
}
