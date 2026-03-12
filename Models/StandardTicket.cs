using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.Models
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seat)
            : base(movieName, price)
        {
            SeatNumber = seat;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"  Seat: {SeatNumber}");
        }
    }
}