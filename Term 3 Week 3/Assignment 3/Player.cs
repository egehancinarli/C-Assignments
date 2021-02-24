using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Assignment_3
{
  public class Player
    {
        public string name;
        public List<PlayingCard> cards = new List<PlayingCard>();
        public Player(string name)
        {
            this.name = name;
            
        }
        public PlayingCard GetNextCard()
        {
      
            PlayingCard NextCard = this.cards[0];


            this.cards.RemoveAt(0);
            return NextCard;



        }
        public void AddCard(PlayingCard card)
        {
            
            cards.Add(card);
          
           
        }
    }
}
