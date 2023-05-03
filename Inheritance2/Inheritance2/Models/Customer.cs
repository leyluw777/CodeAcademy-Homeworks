using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static BaseEntity;
    internal class Customer : BaseEntity
    {
        public Customer(CustomerAdress[]? customerAdresses, CustomerMail[]? customerMails, CustomerPhone[]? customerPhones, Order[]? orders, string? firstName, string? lastName)
        {
            CustomerAdresses = customerAdresses;
            CustomerMails = customerMails;
            CustomerPhones = customerPhones;
            Orders = orders;
            FirstName = firstName;
            LastName = lastName;
        }

        public CustomerAdress[]? CustomerAdresses { get; set; }
        public CustomerMail[]? CustomerMails { get; set; }
        public CustomerPhone[]? CustomerPhones { get; set; }
        public Order[]? Orders { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public void Update(CustomerAdress[]? customerAdresses, CustomerMail[]? customerMails, CustomerPhone[]? customerPhones, Order[]? orders, string? firstName, string? lastName)
        {
            CustomerAdresses = customerAdresses;
            CustomerMails = customerMails;
            CustomerPhones = customerPhones;
            Orders = orders;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}