using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input = "BBABAA";
            //int number = findMinValues(input);
            //Console.WriteLine(number);
            // int[] input = new int[] { 3, 5, 67, 98, 3 };
            // bool strictCount = strictlyIncreasingOrder(input);
            //int reqStat = makeArrayConsecutive2(input);
            //int plusSize = getPlusCountfromSquare(3);
            //int sum = getMaxSum(input);
            //   Console.WriteLine(sum);
            int[] A = { 51,32,43};
            int result = customMetod(A);
            Console.Read();
        }

        private static int customMetod(int[] A)
        {           
            List<LSumofNumber> _sumofNumbers = new List<LSumofNumber>();
            for (int i = 0; i < A.Length; i++)
            {
                LSumofNumber obj = new LSumofNumber();
                obj.sum = SumofNumbers(A[i]);
                obj.Number = A[i];
                _sumofNumbers.Add(obj);
            }
            var result = from p in _sumofNumbers
                         orderby p.sum descending
                         group p by p.sum;
            int iterator = 0;
            int ii = 0;
            int[] aggSum = new int[result.Count()];

            foreach (var item in result)
            {
                int tempsum = 0;
                Console.WriteLine(item.Key + "   " + item.Count());
                if (item.Count() == 1)
                {
                    iterator++;
                }
                if (item.Count() >= 2)
                {
                    int[] indiSum = new int[item.Count()];
                    int temps = 0;
                    foreach (var p in item)
                    {
                        indiSum[temps] = p.Number;
                        //tempsum = tempsum + p.Number;
                        Console.WriteLine("\t{0},{1}", p.sum, p.Number);
                        temps++;
                    }
                    Array.Sort(indiSum);
                    Array.Reverse(indiSum);


                    aggSum[ii] = indiSum[0] + indiSum[1];
                }
               
                ii++;
                
            }
          
            Array.Sort(aggSum);
            Array.Reverse(aggSum);
            Console.WriteLine(aggSum[0]);

            if (iterator == _sumofNumbers.Count)
            {
                return -1;
            }
            else
            {
                return aggSum[0];
            }
           
        }

        public static int SumofNumbers(int n)
        {
            int  sum = 0, m;
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            return sum;

        }
        public class LSumofNumber
        {
            public int sum { get; set; }
            public int Number { get; set; }

        }
        private static int findMinValues(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            string input2 = String.Join("", arr);
            int interator = 0;
            int interator2 = 0;
            int interator4 = 0;
            int interator3 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input2[i])
                {
                    interator++;
                }
            }
            char[] arr2 = input.ToCharArray();
            Array.Sort(arr2);
            Array.Reverse(arr2);
            string input3 = String.Join("", arr2);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input3[i])
                {
                    interator2++;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] !='A')
                {
                    interator3++;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 'B')
                {
                    interator4++;
                }
            }
            int[] result = new int[2];
            //result[0] = interator;
            //result[1] = interator2;
            result[0] = interator3;
            result[1] = interator4;
            Array.Sort(result);
            return result[0];

        }

        private static int findSumofDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        private static int getMaxSum(int[] input)
        {
            int maxSum = Int32.MinValue;
            int tempSum = Int32.MinValue;
            for (int i = 0; i < input.Length - 1; i++)
            {
                tempSum = input[i] * input[i + 1];
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
            }
            return maxSum;
        }

        private static int getPlusCountfromSquare(int n)
        {
            if (n > 1)
            {
                int sum = 0;
                int totalLenght = 2 * n - 1;
                for (int i = 1; i <= n - 1; i++)
                {
                    sum = sum + (totalLenght - 2 * (i));
                }
                return 2 * sum + totalLenght;
            }
            return 1;
        }

        private static int makeArrayConsecutive2(int[] input)
        {
            if (input.Length > 1)
            {
                int tempSum = 0;
                Array.Sort(input);
                for (int i = 0; i < input.Length - 1; i++)
                {
                    int tempDiff = (input[i + 1] - input[i]) > 1 ? (input[i + 1] - input[i]) - 1 : 0;
                    tempSum = tempSum + tempDiff;
                }

                return tempSum;
            }
            return 0;
        }
        private static bool strictlyIncreasingOrder(int[] sequence)
        {
            int tempValue = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                int[] newsequence = sequence.Where((val, idx) => idx != i).ToArray();
                int iterator = 0;
                for (int j = 0; j < newsequence.Length - 1; j++)
                {
                    if (newsequence[j] >= newsequence[j + 1])
                    {
                        break;
                    }
                    else
                    {
                        iterator++;
                    }
                }
                if (newsequence.Length == iterator + 1)
                {
                    tempValue = tempValue + 1;
                }
            }
            return tempValue>0? true:false;
        }
    }
}
