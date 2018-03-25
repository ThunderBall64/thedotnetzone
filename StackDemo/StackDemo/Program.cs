using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacking data content in array
            DemoStack(); 
        }

        private static void DemoStack()
        {
            Stack<string> names = new Stack<string>();
            names.Push("Alpha");
            names.Push("Bravo");
            names.Push("Delta");
            names.Push("Charley");
            names.Push("Eagel");

            Console.WriteLine("Default content of stack");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nPopping '{0}'", names.Pop());
            Console.WriteLine("Peek at next item to display what will" +
                "be destacked: {0}", names.Peek());
            Console.WriteLine("Now, after peek, popping '{0}'", names.Pop());

            Stack<string> stack2 = new Stack<string>(names.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string name in stack2)
            {
                Console.WriteLine(name);
            }

            string[] array2 = new string[names.Count * 2];
            names.CopyTo(array2, names.Count);

            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nContents of the second copy, with " +
                "duplicates and nulls:");

            foreach (string name in stack3)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nstack2.Contains(\"Alpha\") = {0}",
                stack2.Contains("Alpha"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);

            // Display Terminal Command 
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();

        }

        private static void Count(int a)
        {
            Console.WriteLine("a = " + a + " on the stack");

            if (a < 3)
            {
                Count(a + 1);
            }

            Console.WriteLine("a = " + a + " off the stack");
        }
    }
    
}
