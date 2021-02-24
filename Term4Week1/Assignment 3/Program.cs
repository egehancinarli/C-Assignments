using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
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
            //First, we create a pencil and a pencil sharpener.
            Pencil pencil = new Pencil(20);
            PencilSharpener sharpener = new PencilSharpener();
            string message = "";
            while (message != "stop")
            {
                
                Console.Write("Enter a Word: ");
                message = Console.ReadLine();

                if (message == "sharpen")
                    sharpener.Sharpen(pencil);
                else if (message != "stop")
                    pencil.Write(message);//**
            }
            Console.WriteLine("End of the program.");
        }
    }
}
