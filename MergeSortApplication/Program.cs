using System;
using System.Threading.Tasks;

namespace MergeSortApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Any Key To Being Merge Sort");
            Console.ReadKey();

            Console.WriteLine("Generate Random Interger Array\r\n");

            int[] arrayToSort = GenerateRandomIntegerArray(25);

            for (int i = 0; i < 25; i++)
            {
                Console.Write("{0} ", arrayToSort[i]);
            }

            Console.WriteLine("\r\n\r\nBegin Merge Sort Algorithm");

            Task<int[]> sortTask = new MergeSort().Sort(arrayToSort);

            Console.WriteLine("Merge Sort Complete\r\n");

            for (int i = 0; i < 25; i++)
            {
                Console.Write("{0} ", sortTask.Result[i]);
            }

            Console.WriteLine("\r\n\r\nPress Any Key To Exit");
            Console.ReadKey();
        }

        private static int[] GenerateRandomIntegerArray(int length)
        {
            int[] randomArray = new int[length];
            Random rnd = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = rnd.Next(0, length);
            }

            return randomArray;
        }
    }
}
