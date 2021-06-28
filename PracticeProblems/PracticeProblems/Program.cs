using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {30, 40, 2, 5, 1,
                       7, 45, 50, 8};
            int n = arr.Length;
            Console.Write("Minimum number of" +
                              " deletions = " +
             minimumNumberOfDeletions(arr, n));
            Console.Read();

        }

        private static int minimumNumberOfDeletions(int[] arr, int n)
        {
            int[] lis = new int[n];
            for (int i = 0; i < n; i++)
            {
                lis[i] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                    {
                        lis[i] = lis[j] + 1;
                    }
                }
            }
            Array.Sort(lis);
            return n - lis[n - 1];
        }
    }
}
