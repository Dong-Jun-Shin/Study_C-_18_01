using System;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 실수를 입력해주세요.");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 실수를 입력해주세요.");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);
            Console.WriteLine(number1 % number2);
        }
    }
}
