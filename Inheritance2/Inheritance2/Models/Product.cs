using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static NameAuditableEntity;
    internal class Product : NameAuditableEntity
    {
        public Product()
        {

        }


        public Product(Category? category, int categoryId, double? price, int amount, int unitsInStock)
        {
            Category = category;
            CategoryId = categoryId;
            Price = price;
            Amount = amount;
            UnitsInStock = unitsInStock;
        }
    

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public double? Price { get; set; }
        public int Amount { get; set; }
        public int UnitsInStock { get; set; }


        public void Update(Category? category, int categoryId, double? price, int amount, int unitsInStock)
        {
            Category = category;
            CategoryId = categoryId;
            Price = price;
            Amount = amount;
            UnitsInStock = unitsInStock;
        }
    }

}
