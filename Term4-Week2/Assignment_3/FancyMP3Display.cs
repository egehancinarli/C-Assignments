using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
  public  class FancyMP3Display : IObserver
    {
        IObservable MP3Player;
        public FancyMP3Display(IObservable MP3Player)
        {
            this.MP3Player = MP3Player;
            MP3Player.AddObserver(this);
        }
        
        public void Update(Song song)
        {
            Console.WriteLine("Fancy Display: '{0}' by {1} ({2})",song.Title,song.Artist,song.Duration);
        }
    }
}
