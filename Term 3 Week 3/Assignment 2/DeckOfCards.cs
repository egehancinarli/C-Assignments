using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class DeckOfCards
    {
        private List<PlayingCard> AllPlayingCards = new List<PlayingCard>();

        public DeckOfCards()
        {
            AllPlayingCards= InitCards();
            
        }
        private List<PlayingCard> InitCards()
        {
            List<PlayingCard> temporary = new List<PlayingCard>();
            CardSuit[] suits = { CardSuit.Clubs, CardSuit.Diamonds, CardSuit.Hearts, CardSuit.Spades };
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            
            for (int i=0; i<suits.Length;i++)
            {
                for (int o = 0; o <cards.Length; o++)
                {
                    PlayingCard temp = new PlayingCard(cards[o],suits[i]);
                    temporary.Add(temp);
                }
               
            }
            return temporary;
        }
        public void Print()
        {
            for (int i = 0; i < AllPlayingCards.Count; i++)
            {

                Console.WriteLine(AllPlayingCards[i]);
                
            }
        }
        public void Shuffle()
        {
            Console.WriteLine("Shuffling now");
            Random rnd = new Random();
            List<PlayingCard> temp = new List<PlayingCard>();
            List<PlayingCard> newone = new List<PlayingCard>();
            temp = AllPlayingCards;

           while(temp.Count!=0)
            { 
            
                int index = rnd.Next(0, temp.Count);
               newone.Add(temp[index]);
                temp.Remove(temp[index]);
            }
            AllPlayingCards = newone;
        }
    }
}
