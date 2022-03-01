using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Encapsulation
{
    public class Student
    {
        private int studentId;
        private string studentLastName;
        private string studentFirstName;   
        private int studentAge;

        public int Id
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentLastName
        {
            get { return studentLastName; }
            set { studentLastName = value; }
        }

        public string StudentFirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }

        public int StudentAge
        {
            get { return studentAge; }
            set { studentAge = value; }
        }

        public string getFullName()
        {
            string fullName = $"{studentFirstName} {studentLastName}";
            return fullName;
        }

    }
}
