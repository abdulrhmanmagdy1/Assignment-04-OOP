using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment_04_OOP.Models;
using Assignment_04_OOP.Devices;

namespace Assignment_04_OOP.Services
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        private Projector projector = new Projector();

        public string CinemaName { get; set; }

        public Cinema(string name)
        {
            CinemaName = name;
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine();
            Console.WriteLine("========== All Tickets ==========");

            foreach (var t in tickets)
            {
                if (t != null)
                    t.PrintTicket();
            }
        }
    }
}
