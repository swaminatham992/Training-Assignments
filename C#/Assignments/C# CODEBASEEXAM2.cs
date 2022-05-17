using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_base_exam_2
{
    public delegate int Calc(int value1, int value2);
    class programm
    {
        static void Main(string[]args)
        {
            Calc add=(a,b) => a + b;
            Console.WriteLine("Addition:" + add(20, 30));
            Calc sub = (a, b) => a + b;
            Console.WriteLine("Subtraction:" + sub(20, 30));
            Calc mul = (a, b) => a * b;
            Console.WriteLine("Multiplication:" + mul(20, 30));
            Console.WriteLine();


        }
    }
}
