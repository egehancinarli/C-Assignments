using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;


namespace t3w3_assignment_2
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
            
            Customer Messi = new Customer("Lionel Messi",DateTime.Parse("24,06,1987"));
            Customer Piet = new Customer("Piet Paulusma", DateTime.Parse("15,12,1956"));
            PrintCustomer(Messi);
            PrintCustomer(Piet);

            Reservation messi = new Reservation(Messi);
            Reservation piet = new Reservation(Piet);
            List<Ticket> tickets = new List<Ticket>();
            Ticket temp1 = new Ticket("Bohemian Rhapsody",1,new DateTime(2019,02,23,21,30,00),10.50M,6);
            Ticket temp2 = new Ticket("The Prodigy", 4, new DateTime(2019, 02, 23, 22, 00, 00), 10.50M, 16);
            Ticket temp3 = new Ticket("Green Book", 5, new DateTime(2019, 02, 25, 19, 00, 00), 10.50M, 12);
         
           
            tickets.Add(temp1);
            tickets.Add(temp2);
            tickets.Add(temp3);
           
            piet.Tickets = tickets;
            messi.Tickets = tickets;

            messi.PrintReservation();
            piet.PrintReservation();
           

           
            

        }
        void PrintCustomer(Customer c)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c.Name);
            Console.ResetColor();
            
            Console.WriteLine("Date of Birth: {0} \nAge: {1} \nDate of Registeration:" +
                " {2} \nDiscount : {3}",c.Dob,c.Age,c.Date,c.Discount);
        }
    }
}
