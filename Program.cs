using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer();

            Customer[] customers = new Customer[] { customer, customer2 };
            CustomerManager islemler = new CustomerManager();

            islemler.AddCustomer(customer, customer2);
            islemler.ListCustomer(customers);
            islemler.DeleteCustomer(customer);

            Console.WriteLine("\nselected customers deleted \n");

            islemler.ListCustomer(customers);

        }
    }
}
