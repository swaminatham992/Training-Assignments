using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = RMGW58ZLPC0867\\SQLEXPRESS; Initial Catalog=casestudies; user id=sa; password=Temp1234");
            con.Open();
            return con;
        }
        public void introduce(Course course)
        {
            Console.WriteLine(course.Id + " " + course.Name + " " + course.duration + " " + "period" + " " + course.fees);
        }

        public void register(Student student)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = getConnection();

                cmd = new SqlCommand("insert into tblStudent values(@StudentId, @StudentName, @studentDOB)", con);
                cmd.Parameters.AddWithValue("@StudentId", student.Id);
                cmd.Parameters.AddWithValue("@StudentName", student.Name);
                cmd.Parameters.AddWithValue("studentDOB", student.DOB);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row inserted");
                else
                    Console.WriteLine("Not Inserted");


            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex); //instead throw user defined exception
            }
            finally
            {

                con.Close();
            }
        }

        internal void Updatecourse()
        {
            throw new NotImplementedException();
        }

        //public Student[] ListOfStudents()
        //{
        //    Student[] students = new Student[4]
        //    {
        //        new Student(201,'swami','05/14/1997'),
        //        new Student(202,'sumanth','07/23/1999'),
        //        new Student(203,'madhu','09/25/2001'),
        //        new Student(204,'jagan','12/27/2004')
        //    };

        //    return students;
        //}

        //public List<Student> listOfStudents()
        //{
        //    List<Student> students = new List<Student>()
        //    {
        //        new Student(201,'swami','05/14/1997'),
        //        new Student(202,'sumanth','07/23/1999'),
        //        new Student(203,'madhu','09/25/2001'),
        //        new Student(204,'jagan','12/27/2004')
        //    };

        //    return students;
        //}

        //public Course[] ListOfCourses()
        //{
        //    Course[] courses = new Course[4]
        //   {
        //         new Course(10,'Power BI',20,25000),
        //         new Course(20,'Python',40,40000),
        //        new Course(30,'Java',60,55000),
        //        new Course(40,'Azure',80,68000)
        //   };
        //    return courses;
        //}

        //public List<Course> listOfCourses()
        //{
        //    List<Course> courses = new List<Course>()
        //   {
        //        new Course(10,'Power BI',20,25000),
        //        new Course(20,'Python',40,40000),
        //        new Course(30,'Java',60,55000),
        //        new Course(40,'Azure',80,68000)
        //   };
        //    return courses;
        //}

        //public void enroll(Student student, Course course)
        //{
        //    info info = new info();
        //    info.display(student);
        //    info.display(course);
        //}

        //public Enroll[] ListOfEnrollments()
        //{
        //    Enroll[] enroll = new Enroll[3]
        //    {

        //        new Student(201,'swami','05/14/1997'), new Course(10,'Power BI',20,25000),Convert.ToDateTime(DateTime.Now)),
        //        new Student(202,'sumanth','07/23/1999'), new Course(20,'Python',40,40000),Convert.ToDateTime(DateTime.Now)),
        //        new Student(203,'madhu','09/25/2001'), new Course(30,'Java',60,55000),Convert.ToDateTime(DateTime.Now)),
        //        new Student(204,'jagan','12/27/2004'), new Course(40,'Azure',80,68000),Convert.ToDateTime(DateTime.Now)),
        //    };
        //    return enroll;
        //}

        //public List<Enroll> listOfEnrollments()
        //{
        //    List<Enroll> enroll = new List<Enroll>()
        //    {
        //        new Student(201,'swami','05/14/1997'), new Course(10,'Power BI',20,25000),Convert.ToDateTime(DateTime.Now)),
        //        new Student(202,'sumanth','07/23/1999'), new Course(20,'Python',40,40000),Convert.ToDateTime(DateTime.Now)),
        //        new Student(203,'madhu','09/25/2001'), new Course(30,'Java',60,55000),Convert.ToDateTime(DateTime.Now)),
        //        new Student(204,'jagan','12/27/2004'), new Course(40,'Azure',80,68000),Convert.ToDateTime(DateTime.Now)),

        //     
        //    };
        //    return enroll;
        //}

        public void AllStudentDetails()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("Select * from tblStudent", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void UpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter the Student id :", "Enter the Student Name :", "Enter the Student DOB :");
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                string dob = Console.ReadLine();
                con = getConnection();
                cmd = new SqlCommand("update tblStudent get StudentName=@studentname,StudentDOB=@studentdob where StudentId=@studentId", con);
                cmd.Parameters.AddWithValue("@studentId", id);
                cmd.Parameters.AddWithValue("@studentname", name);
                cmd.Parameters.AddWithValue("@studentdob", dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteStudents()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete tblStudent where StudentId=@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Delete Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void ParticularStudent()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Student Id :");
                int  id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from tblStudent where StudentId =@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void AllCoursesLists()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from tblCourse", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2]  + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void ParticularCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id ");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from tblCourse where CourseId=@Courseid", con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void updatestudentCourse()
        {
            try
            {
                Console.WriteLine("Enter the Course id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration :");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Fees :");
                float fee = Convert.ToSingle(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("update tblCourse get Courseduration=@Courseduration,coursename=@coursename,Coursefees=@Coursefees where CourseId=@Courseid", con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                cmd.Parameters.AddWithValue("@Coursename", name);
                cmd.Parameters.AddWithValue("@Courseduration", duration);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res1 = cmd.ExecuteNonQuery();
                if (res1 > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeletestudentCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete tblCourse where CourseId=@courseid", con);
                cmd.Parameters.AddWithValue("@courseid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Delete Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void insertingstudentCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration : ");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Couration Fees : ");
                float fee = Convert.ToSingle(Console.ReadLine());
                cmd = new SqlCommand("insert into tblCourse values(@CourseId, @CourseName, @Courseduration, @Coursefees)", con);
                cmd.Parameters.AddWithValue("@CourseId", id);
                cmd.Parameters.AddWithValue("CourseName", name);
                cmd.Parameters.AddWithValue("@Courseduration", dur);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted");
                }
            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void EnrollstudentDetailslists()
        {
            try
            {
                con = getConnection();

                Console.WriteLine("Enter the Course id :");
                int Id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Id :");
                int Id = Convert.ToInt32(Console.ReadLine());
                DateTime Enrolldate = DateTime.UtcNow;
                cmd = new SqlCommand("insert into tblEnrollDetails values(@Courseid, @StudentId, @EnrollDate)", con);
                cmd.Parameters.AddWithValue("@Courseid", Id1);
                cmd.Parameters.AddWithValue("@StudentId", Id);
                cmd.Parameters.AddWithValue("@EnrollDate", Enrolldate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted ");
                }
            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
