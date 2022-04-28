using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    //studentmarks
    internal class student
    {
        int rollno;
        string name;
        string branch;
        string sem;
        string clas;
        static public void displayresult()
        {
            int[] marks = new int[5];
            marks[0] = 10;
            marks[1] = 20;
            marks[2] = 30;
            marks[3] = 40;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("the marks of " + i + " subs are: " + marks[i]);
            }
            double average = marks.Average();

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("FAILED");
                }
                else if (marks[i] > 35 && average < 50)
                {
                    Console.WriteLine("FAILED");
                }
                else if (average > 50)
                {
                    Console.WriteLine("PASSED");
                }
                else
                {
                    Console.WriteLine("\nthe marks: ");
                }

            }

        }
        public student(int rollno, string name, string branch, string sem, string clas)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.sem = sem;
            this.clas = clas;
            Console.WriteLine($"\nrollno is: {rollno},name is {name}, branch is {branch}, student class is {clas}, sem is {sem}");
        }
        static public void displaydata()
        {
            Console.WriteLine("\nthe marks");
        }

    }
    //car details
    internal class car
    {
        int car_no;
        string car_name;
        string car_type;
        readonly double cost = 700000;
        public car(int car_no, string car_name, string car_type, double cost)
        {
            this.car_no = car_no;
            this.car_name = car_name;
            this.car_type = car_type;
            this.cost = cost;
            Console.WriteLine($"\nthe car_no is {car_no}, car_name is {car_name},car_type is {car_type}, cost is {cost}");
        }
        public void showdetails()
        {
            Console.WriteLine("\nbefore changing");
            Console.WriteLine($"the car_no is {car_no}, car_name is {car_name},car_type is {car_type},costbis {cost}");
        }
        public car(double car_cost)
        {
            Console.WriteLine("\nafter changing");
            car_cost = cost;
            Console.WriteLine($"the car_no is {car_no},car_name is {car_name},car_type is {car_type},cost is {cost}");
        }
    }
    //bank loan
    internal class bank
    {
        double interestrate;
        public void loanCalculator(double loanamt)
        {
            Console.WriteLine("\nplease enter rate of interest");
            interestrate = Convert.ToDouble(Console.ReadLine());
            double interest = (loanamt * interestrate) / 100;
            Console.WriteLine("\nrate of interest for " + interest + "(in percentage) % is : " + interest);
        }
    }
    internal class program
    {
        static void main(string[] args)
        {
            //student
            Student.displayResult();
            student student = new student(23, "swami", "b.tech", "4-1", "mechanical");
            student.displayresult();

            //car
            car car = new car(123,"ferrai", "sports", 5000000);
            car.showdetails();
            car car2 = new car(20000000);

            //bank
            bank bank = new bank();
            Console.WriteLine("\nenter the loan amount: ");
            bank.loanCalculator(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();
        }
    }
}
