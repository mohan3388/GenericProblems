using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GeneicProblem
    {
        public void MaxInt(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item+" ");
            }
            Array.Sort(arr);
            Console.WriteLine("max element is " + arr[arr.Length - 1]);
        }
    }
}
