using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static Inheritance2.Models.NameAuditableEntity;
    internal class Category : NameAuditableEntity
    {
        public Category() { }
        public Category(Product[]? products, string? description)
        {
            Products = products;
            Description = description;
        }

        public void Update(Product[]? products, string? description)
        {
            Products = products;
            Description = description;
        }
        public Product[]? Products { get; set; }
        public string? Description { get; set; }
    }

}