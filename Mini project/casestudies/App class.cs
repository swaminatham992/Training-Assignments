using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }

        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }

    }
    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees;


        public Course(int id, string name, int dura, float fees)
        {
            this.Id = id;
            this.Name = name;
            this.duration = dura;
            this.fees = fees;
        }

    }
    class App
    {
        info info = new info();
        public void Scenerio1()
        {
            Student student = new Student(201, "swami", "12/04/1996");
            Student student1 = new Student(202, "sumanth", "19/08/1998");
            Student student2 = new Student(203, "madhu", "21/05/2000");

            info.Display(student);
            info.Display(student1);
        }
        public void Scenerio2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(221, "raju", "20/02/1998");
            students[1] = new Student(222, "balu", "09/05/2000");
            students[2] = new Student(223, "venu", "28/12/2002");
            for (int i = 0; i < students.Length; i++)
            {
                info.Display(students[i]);

            }
        }
        public void Scenerio3()
        {
            Console.WriteLine("Enter the no.of students want");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Student Id,Name and Date of Birth");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            }
            for (int i = 0; i < student.Length; i++)
            {
                info.Display(student[i]);
            }
        }
        static void Main(string[] args)
        {
            App app = new App();
            AppEngine engine = new AppEngine();
            new UserInterFace().showFirstScreen();
            Console.Read();
        }
    }
}
