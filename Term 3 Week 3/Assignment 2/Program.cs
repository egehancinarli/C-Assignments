using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deck = new DeckOfCards(); 
            deck.Print();
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine();
            deck.Print();

            Console.ReadKey();
        }
        
    }
}
