using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
   public class MP3Player : IObservable
    {
        public List<Song> songs;   
        private  Random rnd = new Random();
        public Song currentSong { get; private set; }
        private List<IObserver> observers;

        public MP3Player()
        {
            observers = new List<IObserver>();
            songs =  new List<Song>();
            AddSongs();
            NextSong();          
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);           
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        // Adding songs in  the list.
        private void AddSongs() 
        {
            songs.Add(new Song("Dazed and confused", "Led Zeppelin", "04:00"));
            songs.Add(new Song("Wish you were here", "Pink Floyd", "03:12"));
            songs.Add(new Song("Billionaire", "Bruno Mars", "03:33"));
            songs.Add(new Song("Tom waits", "Yesterday is here", "02:18"));
        }
        private void NotifyObservers() //fill this one out
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(currentSong);
            }
        }

        public void NextSong()
        {           
            currentSong = songs[rnd.Next(songs.Count)];
            NotifyObservers();          
        }

       
    }
}
