using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    using static Person;
    internal class Student : Person
    {

        #region Fields
        private int _IQRank;
        private int _LangRank;
        public byte _age;
        #endregion

        #region Constructor
        public Student(string name, string surname, byte age, int iqrank, int langrank)
        {
            base.Name = name;
            base.Surname = surname;
            this.Age = age;
            this.IQRank = iqrank;
            this.LangRank = langrank;

        }
        #endregion


        #region Properties
        public int IQRank
        {
            get => _IQRank;

            set
            {
                if (!(value > 0 && value <= 100))
                {
                    throw new Exception("Check your rank value");

                }
                _IQRank = value;
            }
        }


        public int LangRank
        {
            get => _LangRank;

            set
            {
                if (!(value > 0 && value <= 100))
                {
                    throw new Exception("Check your rank value");

                }
                _LangRank = value;
            }
        }


        public override byte Age
        {
            get => _age;
            set
            {
                if (value > 20 || value < 6)
                {
                    throw new Exception("Your age is not allowed for school");
                }
                _age = value;
            }

        } 
        #endregion

    }
 
}

