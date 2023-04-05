using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicket
{
    public class planeticket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }


        public void PrintSummary ()
        {
            Console.WriteLine("Origin {0} ", Origin);
            Console.WriteLine("Destination {0}", Destination);
            Console.WriteLine("Cost {0} ", Cost); 

            if (Currency == "USD" ) {
                Console.WriteLine("Convert to Rupiah {0} ", Cost * 150000);
                    }
            else if (Currency == "IDR")
            {
                Console.WriteLine("Convert to USD {0} ", Cost / 100);
            }
        }
    }
}
