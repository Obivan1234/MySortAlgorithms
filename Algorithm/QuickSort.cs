using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public QuickSort(IEnumerable<T> item) : base(item) { }

        public QuickSort() { }

        protected override void MakeSort()
        {
            Qsort(0, Items.Count - 1);
        }

        private void Qsort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = Sorting(left, right);
            Qsort(left, pivot);
            Qsort(pivot - 1, right);
        }

        private int Sorting(int left, int right)
        {
            throw new NotImplementedException();
        }
    }
}
