﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
  public  class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        float Amount = 5000.00f;
        float Balance;
        string Acc_Name;
        string Acc_Number;

        public Bank()
        {
            Console.WriteLine("Enter the Account Number : ");
            Acc_Number = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            Acc_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : AccountNum {Acc_Number}, Acount Namer {Acc_Name}, Amount is {Amount}");

        }


        public void DepositeAmount()
        {
            Console.WriteLine("Enter the Deposited Amount : ");
            float DepAmount = Convert.ToSingle(Console.ReadLine());

            if (DepAmount == 0)
            {
                Console.WriteLine("Deposite the minimum amount above 1000.00 ");

            }
            else
            {
                Balance = Amount + DepAmount;
                Console.WriteLine("Your Account Balance is After amount deposite : " + Balance);
            }
        }

        public void Amount_Withdrawn()
        {

                Console.WriteLine("Enter the WithDrawn Amount : ");
                float Withdrawn_Amount = Convert.ToSingle(Console.ReadLine());


                if (Withdrawn_Amount > Balance)
                {
                throw (new WithdrawnException("Insufficent balance"));
                }
                else
                {
                    Balance = Balance - Withdrawn_Amount;
                    Console.WriteLine("Your Account Balance is After With Draw the amount :" + Balance);
                }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            try
            {
                bank.DepositeAmount();
                bank.Amount_Withdrawn();

            }
            catch (WithdrawnException WE)
            {
                Console.WriteLine(WE.Message);
            }
            catch(FormatException FE)
            {
                Console.WriteLine($"Enter only numbers ",FE);
            }
            Console.Read();
        }
    }
}
