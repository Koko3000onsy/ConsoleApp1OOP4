using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1OOP4
{
    public class IMAXTicket:Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string moviename, bool is3D) : base(moviename)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {Is3D}");
        }
    }
}
