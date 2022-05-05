using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_base_exam
{
    class Passanger
    {
        public string name { get; set; }
        public int age { get; set; }
        public int dot { get; set; }
        Ticket Ticket { get; set; }
        public Passanger(string name, int age, int DateofTravel)
        {
            name = name;
            age = age;
            DateofTravel = DateofTravel;
            Ticket = new Ticket();
        }
        public void TicketBooking(int tickets)
        {
            Ticket.Tickets = tickets;
            Console.WriteLine("Ticket Booked Successfully");
        }
    }
    class Ticket
    {
        public int tickets;
        public int Tickets
        {
            get => tickets;
            set
            {
                if (value > 5)
                    throw new Exception("Cannot book more than 5 tickets");
                else
                    tickets = value;
            }
        }
    }
    static void Main(string[] args)
    {
        Passanger passanger = new Passanger("swaminatham", 25 - 05 - 2022);
        Console.WriteLine("Enter the number of tickets you want to book:");
        passanger.TicketBooking(int.Parse(Console.ReadLine()));
        Console.ReadKey();


    }
    
}
