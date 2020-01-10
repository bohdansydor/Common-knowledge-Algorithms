using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Task1
    {
        const string taskInfoStr = "Find the minimal positive integer number Q so that the product of digits of Q is exactly equal to N.\n" +
        "Input\n" +
        "The input contains the single integer number N (0 <= N <= 109).\n" +
        "Output\n" +
        "Your program should print to the output the only number Q. If such a number does not exist print -1.\n" +
            "GOOD LUCK!!!\n";
        public Task1()
        {
            taskInfo();
        }

        public void Start()
        {
            int N;
            string str = "";
            while (str != "q")
            {
                Console.WriteLine("Input N");
                N = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result:{smallestNumber(N)}");
                Console.WriteLine("Press 'q' to Test another Task");
                str = Console.ReadLine();
            }
        }
        long smallestNumber(int n)
        {
            if (n >= 0 && n <= 9)
            {
                return n;
            }

            Stack<int> digits = new Stack<int>();

            for (int i = 9; i >= 2 && n > 1; i--)
            {
                while (n % i == 0)
                {
                    digits.Push(i);
                    n /= i;
                }
            }

            if (n != 1)
            {
                return -1;
            }

            long k = 0;

            while (digits.Count != 0)
            {
                k = k * 10 + digits.Pop();

            }

            return k;
        }

        void taskInfo()
        {
            Console.WriteLine(taskInfoStr);
        }
    }
}
