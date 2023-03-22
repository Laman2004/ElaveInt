using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElaveInt
{
    internal class Program
    {
           static void Main(string[] args)
        {
            int[] arr = { 3, 9, 7, 6, 12, 15 };
            int num = 2;
            ElaveInt(arr, num);
        }
        static void ElaveInt(int[] arr,int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
