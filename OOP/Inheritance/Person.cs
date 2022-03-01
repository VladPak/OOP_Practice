using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    public class Person
    {
        public int Id;
        public string Name;
        public string Email;
        public string TelephoneNumber;
        protected int BaseSalary;

        public Person(int id, string name, string email, string telNumber, int baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            TelephoneNumber = telNumber;
            BaseSalary = baseSalary;
        }

        //Common method does not need to be overriden
        public string printNameAndEmail()
        {
            return $"Name: {Name} | Email: {Email}";
        }

        //The virtual method can be overriden in derived classes
        public virtual string printInformation()
        {
            var result = $"!!This is from base class!! \n Id: {Id} \n Name: {Name} " +
                $"\n Email: {Email} \n " +
                $"Telephone number: {TelephoneNumber} \n Base Salary: {BaseSalary }";
            return result;
        }
    }
}
