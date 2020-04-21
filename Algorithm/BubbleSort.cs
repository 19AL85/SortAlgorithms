using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BubbleSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public BubbleSort(IEnumerable<T> items) : base(items) { }
        public BubbleSort()
        {

        }
        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count-1-i; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];

                    if (Compare(a,b) == 1)
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }
    }
}
