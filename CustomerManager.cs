using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.Name + "Müşterisi eklendi");
        }

        public void Delete(Customer customer)
        {
            var itemToRemove = customers.Single(r => r.Name == customer.Name);
            customers.Remove(itemToRemove);
            Console.WriteLine(customer.Name + "Müşterisi silindi");
        }

        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşterimizin adı: " + customer.Name);

            }
        }

    }
}
