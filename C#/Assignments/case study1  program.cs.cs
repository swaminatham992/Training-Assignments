using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study1
{
    public class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string DOB { get; set; }
        public Student(int id,string name,string dob)
        {
            Id = id;
            name = name;
            DOB = dob;

        }
    }
    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees;

        public Course(int id, string name,int dura, float fee)
        {
            this.Id = id;
            this.Name = name;
            this.duration = dura;
            this.fees = fee;

        }
     
    }
    class App
    {
        Info info = new Info();
        public void Scenario1()
        {
            Student student = new Student(101, "swaminatham", "04/01/1999");
            Student student1 = new Student(104, "swami", "12/07/2000");


            info.display(student);
            info.display(student);
        }
        public void Scenario2()
        {
            Student[] student = new Student[2];
            student[0] = new Student(201, "raju", "12/04/1998");
            student[1] = new Student(202, "rahul", "18/02/1999");
            for (int i = 0; i < student.Length; i++)
            {
                info.display(student[i]);
            }
        }
        public void Scenario3()
        {
            Console.WriteLine("Enter the no.of students you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i =0; i< student.Length; i++)
            {
                Console.WriteLine("Enter Student Id, Name and Date of Birth");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());

            }
            for (int i = 0; i < student.Length; i++)
            {
                info.display(student[i]);

            }
        }
        static void Main(string[] args)
        {
            App app = new App();
            AppEngine engine = new AppEngine();
            Console.WriteLine("Display the details using collections:");
            Console.WriteLine();
            foreach(Student studentslist in engine.listOfStudents())
            {
                Console.WriteLine(studentslist.Id + "" + studentslist.name + "" + studentslist.DOB);

            }
            Console.WriteLine();
            Console.WriteLine("----");
            foreach (Course courselist in engine.listOfCourse())
            {
                Console.WriteLine(courselist.Id + "" + courselist.Name + "" + courselist.duration + "" + courselist.fees);
            }
            Console.WriteLine();
            Console.WriteLine("------");
            var lists = from li in engine.listOfEnrollments()
                        select li;
            foreach(var s in lists)
            {
                Console.WriteLine(s._student.Id + "" + s._student.name + "" + s._student.DOB);
                Console.WriteLine(s._course.Id + "" + s._student.Name + "" + s._stuent.duration + "" + s._course.fees);
                Console.WriteLine(s._dateTime);
            }
            new UserInterface().showFirstScreen();
            Console.ReadLine();

        }
        
    }

}
