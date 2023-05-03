using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static BaseEntity;
    internal class Order : BaseEntity
    {
        public Order(int customerId, int customerAdressId, int shipperId, int shipStatusId, DateTime orderDate, DateTime deliveredDate, Shipper? shippers, Customer? customer, CustomerAdress? customerAdress)
        {
            CustomerId = customerId;
            CustomerAdressId = customerAdressId;
            ShipperId = shipperId;
            ShipStatusId = shipStatusId;
            OrderDate = orderDate;
            DeliveredDate = deliveredDate;
            Shippers = shippers;
            Customer = customer;
            CustomerAdress = customerAdress;
        }

        public int CustomerId { get; set; }
        public int CustomerAdressId { get; set; }
        public int ShipperId { get; set; }
        public int ShipStatusId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        
        public Shipper? Shippers { get; set; }
        public Customer? Customer { get; set; }
        public CustomerAdress? CustomerAdress { get; set; }


        public void Update(int customerId, int customerAdressId, int shipperId, int shipStatusId, DateTime orderDate, DateTime deliveredDate, Shipper? shippers, Customer? customer, CustomerAdress? customerAdress)
        {
            CustomerId = customerId;
            CustomerAdressId = customerAdressId;
            ShipperId = shipperId;
            ShipStatusId = shipStatusId;
            OrderDate = orderDate;
            DeliveredDate = deliveredDate;
            Shippers = shippers;
            Customer = customer;
            CustomerAdress = customerAdress;
        }
    }
}
