using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP4
{
    public class Ticket
    {
        public int Ticketid {get;set;}
        public string Moviename {get;set;}
        public decimal Price {get;set;}
        public static int TotalTicket = 0;
        public Ticket(string moviename)
        {
            Ticketid = ++TotalTicket;
            Moviename = moviename;

        }
        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }
        public void Setprice(decimal price)
        {
            Price = price;
        }
        public void Setprice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier; 
        }
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{Ticketid} | {Moviename} | price {Price} EGP | After Tax {PriceAfterTax:F2} EGP");
        }
    }
}
