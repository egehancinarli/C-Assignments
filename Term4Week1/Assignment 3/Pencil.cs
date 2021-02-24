using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;
        public bool CanWrite => nrOfCharsWritten < maxToWrite;  // if written characters are more than the max number bool will be false.
        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
            //Since it's a brand new pencil now, number of written characters will always be 0 for the start.
            nrOfCharsWritten = 0;
        }

        public void AfterSharpening()
        {
            //I'll simply put it to zero so it can go to max again.
            nrOfCharsWritten = 0;          
        }

        public void Write(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(char c in Message)
            {
              // If pencil can still write, it'll print the requested char else, it'll indicate that it's unable to write the character(#).  
                if(CanWrite)
                {
                    Console.Write(c);
                    nrOfCharsWritten++;
                }
                else
                {
                    Console.Write("#");
                }
               
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
