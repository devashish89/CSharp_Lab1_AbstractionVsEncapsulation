using System;

namespace Lab1_AbstractionVsEncapsulation
{
    public class Customer
    {
        //step1: What - User should be able to add Customer (Abstraction - Show only what is necessary)
        //step2: How - Implementation 
        //step3: Madde those complicated methods like Validation logic etc. (Encapsulation - bring down complexity)
        public string CustomerName { get; set; }
        public int CustomerID { get; set; }

        private bool IsValid(string value) //Encapsulation
        {
            return string.IsNullOrEmpty(value) ? false : true;
        }
        public void Insert()
        {
            if(IsValid(CustomerName) && IsValid(CustomerID.ToString()))
            {
                Console.WriteLine("Added Customer: " + CustomerName);
            }
            
        }
    }
}
