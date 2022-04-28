using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class grade
    {
        public string name;
        public int studid;
        public float Grade;
        abstract public Boolean Ispassed(float grade);
    }
    class undergraduate : grade
    {
        public override bool Ispassed(float grade)
        {
            Console.WriteLine("Enter Name of the student is:");
            name = Console.ReadLine();
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine("Enter Student Id");
            if (grade >= 80.0)
            {
                Console.WriteLine("Student's Grade is:");
                return true;
            }
            else
            {
                Console.WriteLine("Student's Grade is: ");
                return false;
            }

        }

    }
    class graduate : grade
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("Enter Name of the Student");
            name = Console.ReadLine();
            Console.WriteLine("Student Nmae: {0}", name);
            Console.WriteLine("Enter Student Id");
            studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("StudentId:{0}", studid);
            if (grade >= 80.0)
            {
                Console.WriteLine("Student's Grade is:");
                return true;

            }
            else
            {
                Console.WriteLine("Student's Grade is:");
                return false;

            }
        }
    }
    public class employee
    {
        public int empid;
        public string empname;
        public float empsalary;

        public Employee (int empId, string empName,float empsalary)
        {
            this.empid = empId;
            this.empname = empName;
            this.empsalary = empsalary;

        }
        public void dispDetails()
        {
            Console.WriteLine($"\nEmpname is {empname}, empid is {empid},salary is {empsalary}");

        }

    }
    public class partTimeemployee
    {
        public int wages = 1500;

        public void showDetails()
        {
            Console.WriteLine($" the parttime employee gets " + wages);

        }

    }
    public class students
    {
        public int st_Id;
        public string st_Name;
        public double exam_fee;


        public void displayDetails()
        {
            Console.WriteLine($"\nthe student {st_Name} with id {st_Id} paid {exam_fee}");
        }
        public void payFee()
        {
            Console.WriteLine("\nenter student id: ");
            st_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student name: ");
            st_Name = Console.ReadLine();
            Console.WriteLine("the exam fee: is" + 2000);
            Console.WriteLine("enter the amount to pay examfee");
            exam_fee = int.Parse(Console.ReadLine());
            double rem_fee = 2000 - exam_fee;
            if (exam_fee == 2000)
            {
                Console.WriteLine("full fees paid no dues");
            }
            else
            {
                Console.WriteLine("the remaining fee: " + rem_fee);
            }
        }
    }
    class DayScholar
    {
        public double transport_fees;

        public DayScholar(double transport_fees)
        {
            this.transport_fees = transport_fees;
            double rem1_fees = 25000 - transport_fees;

            Console.WriteLine("\nthe transport_fess: " + 25000 + " per year");
            Console.WriteLine($"the DayScholar paid {transport_fees},remaining fee is {rem1_fees}");
            Console.WriteLine();

        }
    }
    class Hosteller
    {
        public double Hostel_fee;
        public Hosteller(double Hostel_fee)
        {
            this.Hostel_fee = Hostel_fee;
            double rem2_fees = 35000 - Hostel_fee;
            Console.WriteLine("\nthe Hostel_fee: " + 35000 + "per year");

            Console.WriteLine($"the DayScholar paid {Hostel_fee}, remaining fee is {rem2_fees}");
            Console.WriteLine();
        }
       
    }
    class abstarct
    {
        public static void Main()
        {
            undergraduate ungrd = new undergraduate();
            Console.WriteLine(ungrd.Ispassed(80.0f));
            graduate grd = new graduate();
            Console.WriteLine(grd.Ispassed(70.0f));

            employee employee = new employee(608, "swami", 1500);
            employee.dispDetails();
            partTimeemployee pTemployee = new partTimeemployee();
            pTemployee.showDetails();


            students students = new students();
            students.payFee();
            students.displayDetails();
            Console.WriteLine("enter the transport fee you want to pay");
            DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
            Console.WriteLine("enter the Hosteln fee you want pay");
            Hosteller histeller = new Hosteller(int.Parse(Console.ReadLine()));

            Console.ReadLine();

        }
    }

}
