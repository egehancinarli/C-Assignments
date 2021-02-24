using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3w3_assignment_2
{
    class Reservation
    {
        public Customer customer;
        List<Ticket> tickets;
        private decimal totalPrice;
        public Reservation(Customer C1)
        {
            customer = C1;
            tickets = new List<Ticket>();
        }
        public List<Ticket> Tickets
        {
            get
            {
              return  tickets;
            }
            set
            {
                tickets = value;
                TotalPrice = totalPrice;
            }
           
        }
        public decimal TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                foreach(Ticket t in tickets)
                {


                    if (t.Discount == true)
                    {
                        decimal temp = t.Price - (5 * t.Price) / 100;
                        totalPrice += temp;
                    }
                    else
                    {
                        totalPrice += t.Price;
                    }

                    
                    
                }
                if(customer.Discount==true)
                {
                    totalPrice = totalPrice - (totalPrice / 10);
                  
                }
                
            }
        }
        public void AddTicket(Ticket t)
        {
            tickets.Add(t);
        }
        public void PrintReservation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Creating tickets for : {0} ",customer.Name);
            Console.ResetColor();
            foreach(Ticket t in tickets)
            {
                Console.WriteLine("Created ticket: '{0}' Start time : {1} price : {2:00} room : {3}  ({4}+)",t.movie,t.StartTime,t.Price.ToString(),t.CinemaRoom,t.Minage);
            }
            Console.WriteLine("Total price of reservation : {0}",TotalPrice.ToString("00.00"));
        }


    }
}
