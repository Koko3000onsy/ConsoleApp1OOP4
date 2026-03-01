using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP4
{
    public class StandardTicket :Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket( string moviename , string seat) :base(moviename)
        { 
            SeatNumber = seat;
        }
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Seat {SeatNumber}");
        }
    }
}
