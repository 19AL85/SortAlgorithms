using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BubbleSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count-1-i; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];

                    if (a.CompareTo(b) == 1)
                        Swap(j, j + 1);
                }
            }
        }
    }
}
