using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            Player player1 = new Player("John"); 
            Player player2 = new Player("Emma");

            WarCardGame war = new WarCardGame(player1, player2);
           
            PlayTheGame(war);
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();

            while (!war.EndOfGame())
            {
                
                war.NextCard();
            }
            
            if(war.p1.cards.Count==0)// COME BACK HERE WHEN YOU RE DONE
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0} HAS WON  {1}",war.p2.name,war.p2.cards.Count);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} HAS LOST {1}",war.p1.name, war.p1.cards.Count);
                Console.ResetColor();

            }
            else if(war.p2.cards.Count==0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0} HAS WON {1}", war.p1.name, war.p1.cards.Count);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} HAS LOST {1}", war.p2.name, war.p2.cards.Count);
                Console.ResetColor();
            }                                
        }
    }
}
