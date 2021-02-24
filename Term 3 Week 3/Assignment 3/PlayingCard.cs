using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class PlayingCard
    {

        public int rank;
        public CardSuit suit;


        public PlayingCard(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;

        }

        public override string ToString()
        {
            string card = "";
            switch (rank)
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
                case 14:
                    card += "Ace";
                    break;
                default:
                    card += rank.ToString();
                    break;
            }
            card += " Of " + suit;


            return card;

        }
    }
}
