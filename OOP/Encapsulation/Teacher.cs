using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Encapsulation
{
    public class Teacher
    {
        private int teacherId;
        private string teacherName;
        private string teacherEmail;
        private string teacherPassword;

        public string printTeacherInfo(Teacher teacher)
        {
            return $"==================== \n User Info: {teacher.teacherId} \n User Name: {teacher.teacherName} \n User Email {teacher.teacherEmail} ";
        }

        public int TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }

        public string TeacherEmail
        {
            get { return teacherEmail; }
            set { teacherEmail = value; }
        }

        public string TeacherAccessPassword
        {
            get {
                if (String.IsNullOrEmpty(teacherPassword) || String.IsNullOrWhiteSpace(teacherPassword))
                {
                    return "Password is not confirmed yet";
                }
                else
                {
                    return teacherPassword;
                }                
            }
        }

    }
}
