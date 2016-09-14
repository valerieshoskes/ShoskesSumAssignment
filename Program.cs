using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoskesSumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is {0}", Sum(example));
        }
        static int Sum(int[] myArray)
        {
            int answer = 0;
            foreach (int i in myArray)
            {
                answer += i;
            }
            return answer;
        }
    }
}
