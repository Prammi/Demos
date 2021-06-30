using System.Linq;

namespace OpenCloseAndLiskov
{
    internal class LiskovSumCalculator
    {
        protected readonly int[] _numbers;
        public LiskovSumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public virtual int Calculate() => _numbers.Sum();
    }
}