using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    using static Person;
    internal class Employee : Person 
    {
        #region Constructor
        public Employee(int salaryofhour, int workinghours, string name, string surname, byte age)
        {
            this.SalaryOfHour = salaryofhour;
            this.WorkingHours = workinghours;
            base.Name = name;
            base.Surname = surname;
            this.Age = age;

        }

        #endregion

        #region Properties
        public int SalaryOfHour { get; set; }


        private int _workinghours;
        public int WorkingHours
        {
            get => _workinghours;
            set
            {
                if (value / 30 < 8)
                {
                    throw new Exception("Your daily working hours are less than expected");
                }

                _workinghours = value;
            }
        }

        public byte _age;
        public override byte Age
        {
            get => _age;
            set
            {
                if (value < 18)
                {
                    throw new Exception("Your age is less than expected");
                }
                _age = value;
            }

        }


        #endregion
    }
}
