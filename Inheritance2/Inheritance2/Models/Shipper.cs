using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{

    internal class Shipper
    {
        public Shipper(Order[] orders, string shipperName, string phone)
        {
            Orders = orders;
            ShipperName = shipperName;
            Phone = phone;
        }

        public Order[] Orders { get; set; }
        public string ShipperName { get; set;}
        public string Phone { get; set;}

        public void Update(Order[] orders, string shipperName, string phone)
        {
            Orders = orders;
            ShipperName = shipperName;
            Phone = phone;
        }

    }
}
