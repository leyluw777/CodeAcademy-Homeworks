using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static TitleEntity;
    internal class CustomerPhone : TitleEntity
    {
        public CustomerPhone(Customer? customer, int customerId, int areaCode, int number)
        {
            Customer = customer;
            CustomerId = customerId;
            AreaCode = areaCode;
            Number = number;
        }

        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }

        public int AreaCode { get; set; }
        public int Number { get; set; }

        public void Update(Customer? customer, int customerId, int areaCode, int number)
        {
            Customer = customer;
            CustomerId = customerId;
            AreaCode = areaCode;
            Number = number;
        }
    }
}
