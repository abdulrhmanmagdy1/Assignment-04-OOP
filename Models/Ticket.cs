using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP.Models
{
    public class Ticket
    {
        #region Fields

        private static int ticketCounter = 0;

        #endregion

        #region Properties

        public int TicketId { get; }

        public string MovieName { get; set; }

        public decimal Price { get; private set; }

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        #endregion

        #region Constructor

        public Ticket(string movieName, decimal price)
        {
            ticketCounter++;
            TicketId = ticketCounter;

            MovieName = movieName;
            Price = price;
        }

        #endregion

        #region Methods

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        #endregion

        #region Method Overloading

        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine($"Setting price directly: {price}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }

        #endregion
    }
}