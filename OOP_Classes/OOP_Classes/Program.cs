using OOP_Classes;
using OOP_Classes.Classes;

namespace OOP_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Class1();
            account.Deposit(100);
            var balance = account.GetBalance();

            Console.WriteLine(balance);
            
        }
    }
}