using Api3.Models;

namespace Api3
{
    public static class TestData
    {
        public static void AddTestData(ApiContext context)
        {

            Customer testCustomer1 = new Customer {
                CustomerId = 1,
                CustomerName = "Angelo M. Ullman",
                CustomerPhone = "123456789",
                CustomerAddress = "Angelo Address",
                CustomerEmail = "Angelo@mail.com"
            };

            Customer testCustomer2 = new Customer {
                CustomerId = 2,
                CustomerName = "Maudie V. Hall",
                CustomerPhone = "234567891",
                CustomerAddress = "Maudie Address",
                CustomerEmail = "Maudie@mail.com"
            };

            Customer testCustomer3 = new Customer
            {
                CustomerId = 3,
                CustomerName = "David M. Brooks",
                CustomerPhone = "345678912",
                CustomerAddress = "David Address",
                CustomerEmail = "David@mail.com"
            };

            Customer testCustomer4 = new Customer
            {
                CustomerId = 4,
                CustomerName = "Marcelle S. Padilla",
                CustomerPhone = "456789123",
                CustomerAddress = "Marcelle Address",
                CustomerEmail = "Marcelle@mail.com"
            };

            Customer testCustomer5 = new Customer
            {
                CustomerId = 5,
                CustomerName = "Evelyn S. Bradley",
                CustomerPhone = "567891234",
                CustomerAddress = "Evelyn Address",
                CustomerEmail = "Evelyn@mail.com"
            };

            Customer testCustomer6 = new Customer
            {
                CustomerId = 6,
                CustomerName = "James C. Turner",
                CustomerPhone = "678912345",
                CustomerAddress = "James Address",
                CustomerEmail = "James@mail.com"
            };

            Customer testCustomer7 = new Customer
            {
                CustomerId = 7,
                CustomerName = "Heriberto E. Witte",
                CustomerPhone = "789123456",
                CustomerAddress = "Heriberto Address",
                CustomerEmail = "Heriberto@mail.com"
            };

            Customer testCustomer8 = new Customer
            {
                CustomerId = 8,
                CustomerName = "Carol J. Bender",
                CustomerPhone = "891234567",
                CustomerAddress = "Carol Address",
                CustomerEmail = "Carol@mail.com"
            };

            Customer testCustomer9 = new Customer
            {
                CustomerId = 9,
                CustomerName = "Michelle M. Borror",
                CustomerPhone = "132457689",
                CustomerAddress = "Michelle Address",
                CustomerEmail = "Michelle@mail.com"
            };

            Customer testCustomer10 = new Customer
            {
                CustomerId = 10,
                CustomerName = "Donald P. Tewksbury",
                CustomerPhone = "324576891",
                CustomerAddress = "Donald Address",
                CustomerEmail = "Donald@mail.com"
            };

            Customer testCustomer11 = new Customer
            {
                CustomerId = 11,
                CustomerName = "Kenneth P. Moler",
                CustomerPhone = "245768913",
                CustomerAddress = "Kenneth Address",
                CustomerEmail = "Kenneth@mail.com"
            };

            Customer testCustomer12 = new Customer
            {
                CustomerId = 12,
                CustomerName = "David I. Morris",
                CustomerPhone = "457689132",
                CustomerAddress = "David2 Address",
                CustomerEmail = "David2@mail.com"
            };

            Customer testCustomer13 = new Customer
            {
                CustomerId = 13,
                CustomerName = "David A. Ireland",
                CustomerPhone = "576891324",
                CustomerAddress = "David1 Address",
                CustomerEmail = "David1@mail.com"
            };

            Customer testCustomer14 = new Customer
            {
                CustomerId = 14,
                CustomerName = "Curtis J. Horace",
                CustomerPhone = "768913245",
                CustomerAddress = "Curtis Address",
                CustomerEmail = "Curtis@mail.com"
            };

            Customer testCustomer15 = new Customer
            {
                CustomerId = 15,
                CustomerName = "Lashaun J. Morgan",
                CustomerPhone = "689132457",
                CustomerAddress = "Lashaun Address",
                CustomerEmail = "Lashaun@mail.com"
            };

            Customer testCustomer16 = new Customer
            {
                CustomerId = 16,
                CustomerName = "Joe W. Hanlon",
                CustomerPhone = "891324576",
                CustomerAddress = "Joe Address",
                CustomerEmail = "Joe@mail.com"
            };

            Customer testCustomer17 = new Customer
            {
                CustomerId = 17,
                CustomerName = "Alma J. Olson",
                CustomerPhone = "913245768",
                CustomerAddress = "Alma Address",
                CustomerEmail = "Alma@mail.com"
            };

            Customer testCustomer18 = new Customer
            {
                CustomerId = 18,
                CustomerName = "Brian T. Hayes",
                CustomerPhone = "132337689",
                CustomerAddress = "Brian Address",
                CustomerEmail = "Brian@mail.com"
            };

            Customer testCustomer19 = new Customer
            {
                CustomerId = 19,
                CustomerName = "Deborah G. Kavanaugh",
                CustomerPhone = "324576891",
                CustomerAddress = "Deborah Address",
                CustomerEmail = "Deborah@mail.com"
            };

            Customer testCustomer20 = new Customer
            {
                CustomerId = 20,
                CustomerName = "James S. Gargano",
                CustomerPhone = "245768913",
                CustomerAddress = "James1 Address",
                CustomerEmail = "James1@mail.com"
            };


            context.Customer.Add(testCustomer1);
            context.Customer.Add(testCustomer2);
            context.Customer.Add(testCustomer3);
            context.Customer.Add(testCustomer4);
            context.Customer.Add(testCustomer5);
            context.Customer.Add(testCustomer6);
            context.Customer.Add(testCustomer7);
            context.Customer.Add(testCustomer8);
            context.Customer.Add(testCustomer9);
            context.Customer.Add(testCustomer10);
            context.Customer.Add(testCustomer11);
            context.Customer.Add(testCustomer12);
            context.Customer.Add(testCustomer13);
            context.Customer.Add(testCustomer14);
            context.Customer.Add(testCustomer15);
            context.Customer.Add(testCustomer16);
            context.Customer.Add(testCustomer17);
            context.Customer.Add(testCustomer18);
            context.Customer.Add(testCustomer19);
            context.Customer.Add(testCustomer20);
            context.SaveChanges();
        }
    }
}