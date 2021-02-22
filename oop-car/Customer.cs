using System;
using System.Collections.Generic;
using System.Text;

namespace oop_car
{
    class Customer
    {
        public double hour { get; set; }
        public double leave { get; set; }

        public double price { get; set; }

        public Customer(double _hour, double _leave, double _price)
        {
            this.hour = _hour;
            this.leave = _leave;
            this.price = _price;
        }


        public double calculateCharges()
        {
            if(leave-hour <= 3)
            {
                Console.WriteLine($"You must pay 2$");
                price = 2;
            }
            else
            {
                if(leave-hour == 24)
                 {
                        Console.WriteLine($"You must pay 10$");
                    price = 10;
                 }
                else
                {
                        double value = 2 + ((leave - hour)-3) * 0.50;
                        price = value;
                    if (price > 10)
                        price = 10;
                        Console.WriteLine($"You must pay {price} $");
                    }
                }

            return price;
        }
    }
}
