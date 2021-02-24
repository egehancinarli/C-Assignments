using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class YahtzeeGame
    {
        public dice[] dices = new dice[5];
        public YahtzeeGame()
        {
            Random rnd = new Random();
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i] = new dice(rnd);
            }
        }
        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();
            }
        }
        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            bool iftrue = false;
            int value = dices[0].value;
            if (dices[1].value == value && dices[2].value == value && dices[3].value == value && dices[4].value == value)
            {
                iftrue = true;
            }
            return iftrue;
        }
    }
}
