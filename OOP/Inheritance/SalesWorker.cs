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
            //var result = $"Id: {Id} \n Name: {Name} " +
            //    $"\n Email: {Email} \n " +
            //    $"Telephone number: {TelephoneNumber} \n " +
            //    $"Base Salary: {BaseSalary } \n Bonus Salary: {(BonusForSalary) + BaseSalary}";
            //return result;
        }

        public string showBonusIndeces()
        {
            var result = $"Bonus Amount: {BonusForSalary}";
            return result;
        }
    }
}
