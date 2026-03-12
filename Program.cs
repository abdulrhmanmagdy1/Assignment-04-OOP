#region Part 01 : Theoretical Questions

#region Q1
/*
Q1 : What is the difference between static binding and dynamic binding? When does each one happen?

Static Binding:
Also called early binding. The method call is resolved at compile time.
Example: Method overloading.

Dynamic Binding:
Also called late binding. The method call is resolved at runtime.
Example: Method overriding with virtual/override.

Static binding happens during compilation.
Dynamic binding happens during program execution (runtime).
*/
#endregion

#region Q2
/*
Q2 : What is the difference between method overloading and method overriding?

Method Overloading:
- Same method name
- Different parameters
- Happens in the same class
- Resolved at compile time

Example:
SetPrice(decimal price)
SetPrice(decimal basePrice, decimal multiplier)

Method Overriding:
- Redefining a method from a base class
- Same signature
- Uses inheritance
- Resolved at runtime
*/
#endregion

#region Q3
/*
Q3 : What keywords are used for Method Overriding? What does each one mean?

virtual:
Used in the base class to allow overriding.

override:
Used in the child class to provide a new implementation.

base:
Used to call the base class implementation from the child class.
*/
#endregion

#endregion

using Assignment_04_OOP.Models;
using Assignment_04_OOP.Services;

namespace Assignment_04_OOP
{
    internal class Program
    {
        static void ProcessTicket(Ticket t)
        {
            Console.WriteLine();
            Console.WriteLine("========== Process Single Ticket ==========");
            t.PrintTicket();
        }

        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("VOX");

            cinema.OpenCinema();

            Console.WriteLine();
            Console.WriteLine("========== SetPrice Test ==========");

            StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");

            t1.SetPrice(150);

            t1.SetPrice(100, 1.5m);

            VIPTicket t2 = new VIPTicket("Avengers", 200, true);

            IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            ProcessTicket(t2);

            cinema.CloseCinema();
        }
    }
}