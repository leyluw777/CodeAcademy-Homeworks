using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static TitleEntity;
    internal class CustomerMail : TitleEntity
    {
        public CustomerMail(Customer? customer, int customerId, string? mail)
        {
            Customer = customer;
            CustomerId = customerId;
            Mail = mail;
        }

        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        public string? Mail { get; set; }

        public void Update(Customer? customer, int customerId, string? mail)
        {
            Customer = customer;
            CustomerId = customerId;
            Mail = mail;
        }

    }
}
