using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
  public  class Song
    {
        // This class does not have a override tostring method because we will 
        //  use fancy and simple mp3 display classes to print songs.
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public string Duration { get; private set; }
        public Song(string Title, string Artist ,string Duration)
        {
            this.Title = Title;
            this.Artist = Artist;
            this.Duration = Duration;
        }
        

    }
}
