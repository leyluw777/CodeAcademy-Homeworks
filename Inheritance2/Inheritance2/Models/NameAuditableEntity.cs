using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static BaseEntity;
    internal class NameAuditableEntity : BaseEntity
    {
        public string? Name { get; set; }
    }
}
