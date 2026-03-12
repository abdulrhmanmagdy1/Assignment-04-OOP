using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.Models
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; set; } = 50;

        public VIPTicket(string movieName, decimal price, bool lounge)
            : base(movieName, price)
        {
            LoungeAccess = lounge;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        }
    }
}