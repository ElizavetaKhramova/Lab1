using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 6, 8, 9, 90, 5, 2, 4, 33};
            int result = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result = result + myArray[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
