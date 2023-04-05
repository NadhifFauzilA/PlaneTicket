using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicket
{
    public class Program
    {
        static void Main(string[] args)
        {
            planeticket ticket1 = new planeticket();
            planeticket ticket2 = new planeticket();

            ticket1.Origin = "Jogja";
            ticket1.Destination = "PKU";
            ticket1.Cost = 100;
            ticket1.Currency = "USD";

            ticket2.Origin = "Jakarta";
            ticket2.Destination = "IND";
            ticket2.Cost = 750000;
            ticket2.Currency = "IDR";

            ticket1.PrintSummary();
            ticket2.PrintSummary();


            Console.ReadKey();
        }
    }
}
