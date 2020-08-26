using System;
namespace Lab03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("running");
        }

        public static int Challenge1(int[] array)
        {
            if (array.Length < 3)
                return 0;
            else
            {
                int total = 1;
                for (int i = 0; i < 3; i++)
                {
                    total *= array[i];
                }
                return total;
            }

        }

        //public static int Challenge2(int input)
        //{

        //}
    }
}