using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes.Classes
{
    internal class Class1
    {
        private int _balance;
        public int GetBalance()
        {
            return _balance;
        }
        public void Deposit(int amount)
        {
            _balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (_balance - amount >= 0)
            {
                _balance -= amount;
            }
        }
    }
}
