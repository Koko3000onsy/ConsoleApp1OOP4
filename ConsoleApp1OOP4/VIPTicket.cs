using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP4
{
    public class VIPTicket:Ticket
    {
        public bool LoungeAccess {  get; set; }
        public decimal ServiceFee { get; set; }
        public VIPTicket(string moviename, bool lounge,decimal Fee) : base(moviename)
        {
          LoungeAccess = lounge;
            ServiceFee = Fee;
        }
        public override void PrintTicket()
        {
              base.PrintTicket();
              Console.WriteLine($"Lounge Access {LoungeAccess} | Service Fee {ServiceFee} EGP");
        }
    }
}
