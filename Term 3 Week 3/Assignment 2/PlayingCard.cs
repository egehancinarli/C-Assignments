using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class PlayingCard
    {
        private int rank;
        private CardSuit suit;
       
        

        public PlayingCard(int rank,CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
          
        }
        
        public override string ToString()
        {
            string card = "";
            switch(rank)
            {
                case 1:
                    card += "Ace";
                    break;
                case 11:
                    card += "Jack";
                    break;
                case 12:
                    card += "Queen";
                    break;
                case 13:
                    card += "King";
                    break;
                default:
                    card += rank.ToString();
                    break;
            }
            card += " OF " + suit;
            
            
            return card;
         
        }
    }
}
