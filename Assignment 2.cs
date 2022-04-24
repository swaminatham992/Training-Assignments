using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int[] ar = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("the element at " + i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }

            //reverse array
            Console.WriteLine("enter the array size");
            int[] ar1 = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = ar.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("the element at " + i);
                ar1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the elements in the array are:");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar1[i]);
            }
            //2nd original array
            Console.WriteLine("enter the 2nd array size");
            int[] ar5 = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0); int <ar5. length; int++)
            {
            Console.WriteLine("the serial elements in the 3rd array are:");
            for (int i = 0; i < ar5.Length; i++)
            {
                 Console.WriteLine(ar5[i]);
            }

            //2nd reverse array
            Console.WriteLine("the reversed elements in the 4th array are:");
                for (int i = ar5.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(ar5[i]);
                }

            //accept and display string

            Console.WriteLine("\nenter a string");
            string s1 = Console.ReadLine();
            Console.WriteLine("the given input: " + s1);

            //string reverse

            Console.WriteLine("\nenter a string");
            string s2 = Console.ReadLine();
            string revs = "";
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                   revs += s2[i].ToString();

            }
            Console.WriteLine("the reversed string: " + revs);
            Console.WriteLine("the reversed string: " + revs");
            //palindrome
            console.writeline("\nenter a string ");
            string s = Console.ReadLine();
            string rev = "";
            for (int i=s.Length-1; i>=0; i--)
            {
                    rev += s[i].ToString();
            }
            if (rev==s)
            {
                    Console.WriteLine("the string is {0} and reversed string is {1}", s, rev);
            }  
            else
            {
                    Console.WriteLine("not a palindrome");
            }
            Console.ReadLine();

                  
    }
}
