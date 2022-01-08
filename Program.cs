using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Parking_Charges_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            int CustomersNumber;

            WriteLine("Enter the number of customers ");
            CustomersNumber = int.Parse(ReadLine());

            for (int i = 1; i <= CustomersNumber; i++)
            {
                WriteLine("Please enter the number of hours for customer {0}", i);

                Customer customer = new Customer(ToDouble(ReadLine()));

                WriteLine("Customer {0} the total charges are {1:C2}", i, customer.CalculateCharges());
            }
        }
    }
}
