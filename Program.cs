using System;
using System.Linq;

namespace AltexSoft_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Write your number");
            do
            {

                string num = Console.ReadLine();

                if (4 > num.Length && num.Length < 8)
                {
                    Console.WriteLine("Wrong Number! Please enter number 4-8 digits long");
                }
                else if (num.Length % 2 == 1)
                {
                    num = "0" + num;

                }
                int[] arr_int = Array.ConvertAll(num.ToCharArray(), c => (int)Char.GetNumericValue(c));
                int[] part1 = new int[num.Length / 2];
                int[] part2 = new int[num.Length / 2];
                Array.Copy(arr_int, 0, part1, 0, num.Length / 2);
                Array.Copy(arr_int, num.Length / 2, part2, 0, num.Length / 2);
                if (part1.Sum() == part2.Sum())
                {
                    Console.WriteLine("Your number is lucky");
                }
                else
                {
                    Console.WriteLine("Your number is not lucky");
                }
            }
            while (true);
        }
    }
}
