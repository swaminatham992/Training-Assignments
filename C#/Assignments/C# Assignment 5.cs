﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        class Bank
        {
            int money = 3000;
            String acc_name = "raj";
            String acc_num;
            static String bank_name = "IndusInd";
            static public int updatedBalance;
            public void depositMoney()
            {

                Console.WriteLine("\nEnter the amount you want to deposit:");
                int depMoney = int.Parse(Console.ReadLine());
                updatedBalance = money + depMoney;
                if (depMoney == 0)
                {
                    Console.WriteLine("minimum deposit should be 100 ");
                }
                else
                {
                    Console.WriteLine("updated balance of " + acc_name + " after deposit is " + updatedBalance);
                }

            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Welcome " + acc_name + " your accountbalance: " + updatedBalance);
                    Console.WriteLine("\nEnter the amount you want to withdraw:");
                    int withdraw = int.Parse(Console.ReadLine());
                    updatedBalance = updatedBalance - withdraw;
                    if (withdraw > updatedBalance)
                    {
                        Console.WriteLine("insuffiecient balance");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of " + acc_name + " after withdrawal is " + updatedBalance);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("enter balance in number not in words inputmissmatch exception ");
                }
            }
            public void Balance()
            {
                Console.WriteLine("welcome to the " + bank_name + "bank ");
                Console.WriteLine("Enter account number: ");
                acc_num = Console.ReadLine();
                Console.WriteLine("Welcome " + acc_name + " your accountbalance: " + money);

            }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Balance();
            bank.depositMoney();
            bank.withdrawMoney();
            Console.ReadLine();
        }
       
    }
}
