using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_AbstractionVsEncapsulation;

namespace Main_Calling
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab1_AbstractionVsEncapsulation.Customer cust = new Lab1_AbstractionVsEncapsulation.Customer();
            cust.CustomerID = 1;
            cust.CustomerName = "Deva";

            cust.Insert(); //Abstraction - allowing end user to see what is required for him by implementing encapsulation of complicated logic validation of Inputs etc.
        }
    }
}
