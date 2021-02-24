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
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }
        void Start()
        {
            YahtzeeGame game = new YahtzeeGame();
            PlayYahtzee(game);
        }

        void PlayYahtzee(YahtzeeGame game)
        {
            int nrOfAttempts = 0;

            do
            {
                game.Throw();
                game.DisplayValues();

                nrOfAttempts++;

            } while (game.Yahtzee() != true);

            Console.WriteLine("Number of attempts needed (Yahtzee): {0}", nrOfAttempts);
        }
    }
}
