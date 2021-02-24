using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            //We are sharpening the pencil that passed in as a parameter. Now it can write to max again.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sharpening the pencil...");
            Console.ResetColor();
            pencil.AfterSharpening();
        }
    }
}
