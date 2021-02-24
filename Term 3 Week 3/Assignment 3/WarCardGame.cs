using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Assignment_3
{
    public class WarCardGame : CardGame
    {
        public Player  p1 = new Player("John");
        public  Player p2 = new Player("Emma");
        
        public WarCardGame(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;
           
          
        }
        public void StartNewGame()
        {   
            int counter = 0;
            Deck.Shuffle();
            while(counter<52)
            {
                if(counter==0|| counter%2==0)
                {
                    p1.AddCard(Deck.AllPlayingCards[counter]);
                }
                else if (counter==1||counter%2==1)
                {
                    p2.AddCard(Deck.AllPlayingCards[counter]);
                }
     
                counter++;
            }
            



        }
        public bool EndOfGame()
        {
            bool isGameEnded;
            if(p1.cards.Count==0||p2.cards.Count==0)
            {
                isGameEnded = true;
            }
            else
            {
                isGameEnded = false;
            }
         
           
                return isGameEnded;
        }
        public void NextCard()
        {
           PlayingCard tempP1 = p1.GetNextCard();
           PlayingCard tempP2 = p2.GetNextCard();
            Console.WriteLine("[{0}] {1}  -  [{2}] {3} ",p1.name,tempP1.ToString(),p2.name,tempP2.ToString());
            if(tempP1.rank>tempP2.rank)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0} has taken {1}'s card",p1.name,p2.name);
                p1.AddCard(tempP1);
                p1.AddCard(tempP2);
                Console.ResetColor();
                
            }
            else if (tempP2.rank>tempP1.rank)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("{0} has taken {1}'s card", p2.name, p1.name);
                p2.AddCard(tempP2);
                p2.AddCard(tempP1);
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards are lost...");
                Console.ResetColor();

            }
            
        }
       
    }
}
