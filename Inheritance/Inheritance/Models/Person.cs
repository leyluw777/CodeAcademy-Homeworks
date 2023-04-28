using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Person 
    {

        #region Properties

        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public virtual byte Age { get; set; } 
        #endregion

    }
}
