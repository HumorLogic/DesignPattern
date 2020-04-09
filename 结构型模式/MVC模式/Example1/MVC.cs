using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MVC_Pattern.Example1
{

    class program
    {
        //public static void Main(string[] arg)
        //{
        //    Student model = RetriveStudentFromDatebase();
        //    StudentView view = new StudentView();
        //    StudentController controller = new StudentController(model, view);

        //    controller.UpdateView();
        //    Console.WriteLine("\n");
            
        //    controller.SetStudentName("John");
        //    controller.UpdateView();
        //    Console.WriteLine("\n");

        //    controller.SetStudentRollNo("18");
        //    controller.UpdateView();
        //    Console.WriteLine("\n");

        //}

        private static Student RetriveStudentFromDatebase()
        {
            Student student = new Student();
            student.SetName("Peter");
            student.SetRollNo("10");
            return student;
        }

    }
  public class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void SetStudentName(string name)
        {
            model.SetName(name);
        }

        public string GetStudentName()
        {
            return model.GetName();
        }

        public void SetStudentRollNo(string rollNo)
        {
            model.SetRollNo(rollNo);
        }

        public string GetStudentRollNo()
        {
            return model.GetRollNo();
        }

        public void UpdateView()
        {
            view.PrintStudentDetails(model.GetName(), model.GetRollNo());
        }
    }

    /// <summary>
    /// Create View
    /// </summary>
    public class StudentView
    {
        public void PrintStudentDetails(string studentName,string studentRollNo)
        {
            Console.WriteLine("Student:");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Roll No: " + studentRollNo);

        }
    }


    /// <summary>
    /// Create Model
    /// </summary>
    public class Student
    {
        private string rollNo;
        private string name;

        public string GetRollNo()
        {
            return rollNo;
        }

        public void  SetRollNo(string rollNo)
        {
            this.rollNo = rollNo;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
