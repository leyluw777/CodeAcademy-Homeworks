using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static TitleEntity;
    internal class CustomerAdress : TitleEntity
    {

        public CustomerAdress(Customer? customer, int customerId, string? country, string? city, string? town, string? street, string? building, int? no, Order[] orders)
        {
            Customer = customer;
            CustomerId = customerId;
            Country = country;
            City = city;
            Town = town;
            Street = street;
            Building = building;
            No = no;
            Orders = orders;
        }

        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Town { get; set; }
        public string? Street { get; set; }
        public string? Building { get; set; }
        public int? No { get; set; }
        public Order[] Orders { get; set; }


        public void Update (Customer? customer, int customerId, string? country, string? city, string? town, string? street, string? building, int? no, Order[] orders)
        {
            Customer = customer;
            CustomerId = customerId;
            Country = country;
            City = city;
            Town = town;
            Street = street;
            Building = building;
            No = no;
            Orders = orders;
        }


    }
}
