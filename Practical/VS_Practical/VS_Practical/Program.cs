using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VS_Practical
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Jay",
                    age = 21,
                    lastName = "Prajapati"
                },
                new Customer
                {
                    Name = "Jhon",
                    age = 22,
                    lastName = "Doe"
                },
                new Customer
                {
                    Name = "Dev",
                    age = 30,
                    lastName = "Patel"
                }
            };
            var customer1 = JsonConvert.SerializeObject(customers);
            Console.WriteLine("Serializable \n\n" + customer1);
            var customer2 = JsonConvert.DeserializeObject(customer1);
            Console.WriteLine("\n\nDeserializable \n\n" + customer2);
            Console.ReadKey();
        }
        [Serializable]
        private class Customer
        {
            public string Name { get; set; }
            public int age { get; set; }
            public string lastName { get; set; }
        }
    }
}