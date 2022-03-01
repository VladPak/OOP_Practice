using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            //Student student = new Student();
            //Teacher teacher = new Teacher();

            //teacher.TeacherId = 1;
            //teacher.TeacherName = "Nikolay";
            //teacher.TeacherEmail = "nikola@gmail.com";

            ////Assign values to Student's fields with Set Accessors
            //student.Id = 1;
            //student.StudentLastName = "Pak";
            //student.StudentFirstName = "Vladimir";
            //student.StudentAge = 27;

            ////Get and display Student's fields with Get Accessors
            //Console.WriteLine($"Student Information \n ID: {student.Id} \n Fullname: {student.getFullName()} \n Age: {student.StudentAge} ");
            //Console.WriteLine(teacher.TeacherAccessPassword);
            #endregion

            #region Inheritance
            SalesWorker salesWorker = new SalesWorker(1, "Alex", "alex432@gmail.com", "5558899", 800, 100);
            Admin admin = new Admin(10, "Mikhail", "mishka91@gmail.com", "8795544", 600, "softmaster384");

            Console.WriteLine(salesWorker.printInformation());
            Console.WriteLine(salesWorker.showBonusIndeces());

            //Console.WriteLine(admin.printInformation());
            //Console.WriteLine(admin.printNameAndEmail());
            #endregion

            #region Polymorphism
            //Simple simple = new Simple();
            //simple.RoomId = 1;
            //simple.RoomType = "Simple (One Bed)";
            //simple.RoomCost = 300;
            //simple.isOccupied = true;
            //simple.isReserved = true;

            //Free free = new Free();
            //free.RoomId = 1;
            //free.RoomType = "Free (One Bed)";
            //free.RoomCost = 0;
            //free.isOccupied = true;
            //free.isReserved = true;

            //Console.WriteLine(free.printRoomCostForType());
            //Console.WriteLine(simple.printRoomCostForType());
            #endregion

            #region Abstraction
            #endregion
        }
    }
}
