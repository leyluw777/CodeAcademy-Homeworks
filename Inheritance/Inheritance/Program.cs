using Inheritance.Models;


namespace Inheritance
{
    internal class Program
    {

        #region Employee class method
        public static int CalculateSalary(int salaryofhour, int workinghours)

        {

            if (salaryofhour * workinghours < 250)
            {
                throw new Exception("Your salary should be greater than 250 AZN");
            }
            return salaryofhour * workinghours;
        }
        #endregion

        #region Student method
        public static double ExamResult(int iqrank, int langrank)
        {
            if (iqrank + langrank < 120)
            {
                throw new Exception("Your exam result is lower than expected");
            }
            return iqrank + langrank;
        } 
        #endregion

        static void Main(string[] args)
        {

            #region Employee class
            Employee firstE = new(20, 300, "Lela", "Imanova", 22);
            int totalSalary = CalculateSalary(firstE.SalaryOfHour, firstE.WorkingHours);
            Console.WriteLine($@"
First name                    : {firstE.Name}
Last name                     : {firstE.Surname}
Age                           : {firstE.Age}
TotalSalary                   : {totalSalary}
Salary per hour               : {firstE.SalaryOfHour}
Working hours per month       : {firstE.WorkingHours}
             ");

            #endregion


            #region Student class
            Student firstS = new("Leila", "Imanova", 18, 100, 100);
            double examResult = ExamResult(firstS.IQRank, firstS.LangRank);
            Console.WriteLine($@"
First name                    : {firstS.Name}
Last name                     : {firstS.Surname}
Age                           : {firstS.Age}
IQ Rank                       : {firstS.IQRank}
Language Rank                 : {firstS.LangRank}
Exam result                   : {examResult}
");
            #endregion
        }

        }
    }