using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var str= Console.ReadLine();
            for (int index = 0; index < str.Length; index = index + 2)
            {
                Console.WriteLine(str[index]);
            }
           

            
        }
    }
}
