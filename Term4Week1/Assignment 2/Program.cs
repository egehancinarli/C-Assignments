using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }
        void Start()
        {
            IStack myStack = new ArrayStack(50);
            Console.WriteLine("Pushing values... \n");
            AddValues(myStack);

            Console.WriteLine("\nPlease enter a value to see if it's in the stack");
            int value = int.Parse(Console.ReadLine());

            CheckValues(myStack,value);

            Console.WriteLine("\n Popping values... \n");
            ProcessValues(myStack);
            
        } // ADD CONTAINS
        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = rnd.Next(100);
                stack.Push(value);
              //  Console.WriteLine("+++++++"+stack.Count);
                Console.WriteLine($"pushed {value},new count: {stack.Count}");
            }
        }
        // For testing contains method.
        void CheckValues(IStack ArrayStack,int value)
        {
            if(ArrayStack.Contains(value))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n{0} is present in the stack!!",value);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOops, {0} is not present in the stack",value);
            }
            Console.ResetColor();
        }


        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
              //  Console.WriteLine("------------- " + stack.Count);
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
                
            }
        }
    }
}
