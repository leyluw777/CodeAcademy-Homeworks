using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2.Models
{
    using static Inheritance2.Models.BaseEntity;
    internal class TitleEntity : BaseEntity
    {
        public string Title { get; set; }
    }
}
