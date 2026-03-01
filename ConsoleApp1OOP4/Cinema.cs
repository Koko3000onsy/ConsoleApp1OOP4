using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP4
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[10];
        private int count = 0;
        public string Name { get; set; }
        public Cinema(string name)
        {
            Name = name;
        }
        public void OpenCinema()
        {
            Console.WriteLine("========= Cinema Opened =========");
            Console.WriteLine("Projector started.");
        }
        public void CloseCinema()
        {
            Console.WriteLine("========= Cinema Closed =========");
        }
        public void AddTicket(Ticket t)
        {
            tickets[count++] = t;
        }
        public void PrintAllTickets()
        {
            Console.WriteLine("\n========= All Tickets =========");
            for (int i = 0; i < count; i++)
            {
                tickets[i].PrintTicket();   
                Console.WriteLine();
            }
        }
        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========= Process Single Ticket =========");
            t.PrintTicket();   
        }
    }
}
