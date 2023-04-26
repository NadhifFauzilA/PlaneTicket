using System;

namespace PlaneTicket
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Global Variable
            string User_name;
            string Destination;

            // Class Declaration
            planeticket ticket = new planeticket();
            planeticket ticket2 = new planeticket();
            plane test = new plane();

            // Main Code
            Console.Write("Please Insert Username : ");
            User_name = Console.ReadLine();

        mainmenu:

            Console.WriteLine("Masukan Tujuan Perjalalanan ");
            Console.Write("Available : Jogjakarta , jakarta : ");
            Destination = Console.ReadLine();

            if (Destination == "jogjakarta" || Destination == "JOGJAKARTA")
            {
                ticket.Username = User_name;
                ticket.Origin = "Jogjakarta";
                ticket.Destination = "PKU";
                ticket.Cost = 100;
                ticket.Currency = "USD";
                ticket.PrintSummary();
                Console.WriteLine("Press any button to Continue");
                Console.ReadKey();
                Console.Clear();
                goto mainmenu;

            }
            else if (Destination == "jakarta" || Destination == "JAKARTA")
            {
                ticket.Username = User_name;
                ticket.Origin = "Jakarta";
                ticket.Destination = "IND";
                ticket.Cost = 750000;
                ticket.Currency = "IDR";
                ticket.PrintSummary();
                goto mainmenu;
            }
            else if (Destination == "Palembang" || Destination == "PALEMBANG")
            {



            }
            else
            {
                Console.WriteLine("Destination Not Found ");
            }
            Console.ReadKey();
        }
    }
}
