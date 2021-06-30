using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseAndLiskov
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public int Calculate() => _numbers.Sum();
    }
}
