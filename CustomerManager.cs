using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer addcustomer, Customer addcustomer2)
        {
            addcustomer.Name = "Gül";
            addcustomer.Surname = "Toksöz";
            addcustomer.Id = "74185296345";
            addcustomer.Salary = 5000;
            addcustomer.MaxCredit = (addcustomer.Salary / 4);

            addcustomer2.Name = "Kerem";
            addcustomer2.Surname = "Alaşan";
            addcustomer2.Id = "74185753945";
            addcustomer2.Salary = 4500;
            addcustomer2.MaxCredit = (addcustomer2.Salary / 5);
        }

        public void ListCustomer(Customer[] customers )
        {
            foreach (var listcustomer in customers)
            {
                if(listcustomer.Id == "")
                {
                    continue;
                }
                Console.WriteLine("Customer id : " + listcustomer.Id);
                Console.WriteLine("Customer Name : " + listcustomer.Name);
                Console.WriteLine("Customer Surname : " + listcustomer.Surname);
                Console.WriteLine("Customer Salary : " + listcustomer.Salary);
                Console.WriteLine("Customer Max Credit : " + listcustomer.MaxCredit);
                Console.WriteLine("-----*-----");

            }
            Console.WriteLine("------**------");
        }

        public void DeleteCustomer(Customer deletecustomer)
        {
            deletecustomer.Id = "";
            deletecustomer.Name = "";
            deletecustomer.Surname = "";
            deletecustomer.Salary = 0;
            deletecustomer.MaxCredit = 0;
        }
    }
}
