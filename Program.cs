using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer
            {
                id=1,
                Name="burak"
            });

            customerManager.Add(new Customer
            {
                id = 2,
                Name = "ibrahim"
            });
            customerManager.List();
            customerManager.Delete(new Customer
            {
                id = 2,
                Name = "ibrahim"
            });
            customerManager.List();
            Console.ReadLine();
        }
    }
}
