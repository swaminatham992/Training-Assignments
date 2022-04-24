using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
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

            //find min,max & avg
            Console.WriteLine("Enter array size");
            int[] ari = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("the elements at " + i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the elements are");
            for (int i = 0; i < ar.Length; i++)
            {

                Console.Write(ar[i] + " ");
            }
            Console.WriteLine("\nthe average of elements: " + ar.Average());
            Console.WriteLine("the min element: " + ar.Min() + " " + "and " + "the max element: " + ar.Max());

            //marks
            Console.WriteLine("\nEnter marks");
            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("the elements at " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("the elements are");
            for (int i = 0; i < 10; i++)
            {

                Console.Write(arr[i] + " ");
            }

            //asscending 
            Array.Sort(arr);
            Console.WriteLine("\narray after sort in ascending order...");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            //descending
            Array.Reverse(arr);
            Console.WriteLine("\narray after sort in descending order...");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }



            Console.WriteLine("\nthe sum of elements: " + arr.Sum() + " " + "and " + "the average of element: " + arr.Average());
            Console.WriteLine("\nthe min element: " + arr.Min() + " " + "and " + "the max element: " + arr.Max());


            //accept and display string

            Console.WriteLine("enter a string");
            String s2 = Console.ReadLine();
            Console.WriteLine("the given input : " + s2);


            //reverse of a string

            string s, rev = "";
            Console.WriteLine("enter string name");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            Console.WriteLine("the reversed string is :" + rev);

            //two strings same or not
            string one = Console.ReadLine();
            string two = Console.ReadLine();

            Console.WriteLine("enter string two : ");
            if (one.Equals(two))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }


            //palindrome or not

            string s1, revs = "";
            Console.WriteLine(" enter string name");
            s1 = Console.ReadLine();
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                revs += s1[i].ToString();
            }
            if (revs == s1)
            {
                Console.WriteLine("  the give string is polindrome ");
            }
            else
            {
                Console.WriteLine("given string is not polindrome");
            }
            Console.ReadLine();

        }
    }
}
