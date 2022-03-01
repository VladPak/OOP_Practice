using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    public class Admin : Person
    {
        public string keyWord;

        public Admin(int id, string name, string email, string telNumber, int baseSalary, string _keyWord) : base(id, name, email, telNumber, baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            TelephoneNumber = telNumber;
            BaseSalary = baseSalary;
            keyWord = _keyWord;
        }

        public override string printInformation()
        {
            var result = $"Id: {Id} \n Name: {Name} " +
                $"\n Email: {Email} \n " +
                $"Telephone number: {TelephoneNumber} \n " +
                $"Base Salary: {BaseSalary } \n Keyword: {keyWord}";
            return result;
        }
    }
}
