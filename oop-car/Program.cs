using System;
using System.Net.Http;

namespace oop_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer mycustomer = new Customer(6.30, 10.30, 0);
            Customer mycustomer2 = new Customer(0, 23, 0);
            Customer mycustomer3 = new Customer(9.30, 10.30, 0);
            double total = mycustomer.calculateCharges()+ mycustomer2.calculateCharges()+ mycustomer3.calculateCharges();
            Console.WriteLine($"Total = {total}");
        }
    }
}
