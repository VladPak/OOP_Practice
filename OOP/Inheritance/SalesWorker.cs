using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    public class SalesWorker : Person
    {
        public int BonusForSalary;

        public SalesWorker(int id, string name, string email, string telNum, int baseSalary, int bonusForSalary) : base(id, name, email, telNum, baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            TelephoneNumber = telNum;
            BaseSalary = baseSalary;
            BonusForSalary = bonusForSalary;
        }


        public override string printInformation()
        {
            return base.printInformation();
        }

        public string showBonusIndeces()
        {
            var result = $"Worker Id: {Id} \n Base salary: {BaseSalary} \n Bonus Amount: {BonusForSalary} " +
                $"\n Total Salary: {BaseSalary + BonusForSalary}";
            return result;
        }
    }
}
