using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class info
    {
        public void Display(Student student)
        {
            Console.WriteLine($"The student details student id is {student.Id}, student name is {student.Name}, student dob is {student.DOB}");

        }

        public void Display(Course course)
        {
            Console.WriteLine($"The course id is {course.Id}, course name is {course.Name}, couse duration is {course.duration}, corse fee is {course.fees}");
        }

        public void DisplayEnrolldetails(Enroll enroll)
        {
            Display(enroll._student);
            Display(enroll._course);
            Console.WriteLine(enroll._dateTime);
        }
    }
}
