using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace t3w3_assignment_2
{
    class Ticket
    {
        private string movieName;
        private int cinemaRoom;
        private DateTime startTime;
        private decimal price;
        private int minimumage;
        private bool discount;
        public Ticket(string movieName,int cinemaRoom,DateTime startTime,decimal price,int minimumage)
        {
            this.movie = movieName;
            this.Minage = minimumage;
            this.Price = price;
            this.StartTime = startTime;
            this.CinemaRoom = cinemaRoom;
            Discount = discount;
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price=value;
            }
        }
        public bool Discount
        {
            get
            {
                return discount;
            }
            set
            {
                if(startTime.DayOfWeek==DayOfWeek.Monday || startTime.DayOfWeek == DayOfWeek.Tuesday)
                {
                    discount = true;
                }
                else
                {
                    discount = false;
                }
            }
        }
        public string movie
        {
            get
            {
                return movieName;
            }
            set
            {
               
               if(value!=null&&value!=" ")
                {
                    movieName = value;
                } 
            }
        }
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                if (value.Minute == 30 || value.Minute == 00)
                {
                    startTime = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Error Occured: Invalid start hour ({0})! ", value);
                    Console.ResetColor();
                }
                
            }
        }
        public int CinemaRoom
        {
            get
            {
                return cinemaRoom;
            }
            set
            {
                if(value==1||value==2||value==3||value==4||value==5)
                {
                    cinemaRoom = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Error Occured: Invalid cinema room ({0})! ", value);
                    Console.ResetColor();
                }
            }
        }
        public int Minage
        {
            get
            {
                return minimumage;
            }
            set
            {
                if(value==0||value==6||value==9||value==12||value==16)
                {
                    minimumage = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Error Occured: Invalid minimum age ({0})! ",value);
                    Console.ResetColor();
                }
            }
        }
    }
}
