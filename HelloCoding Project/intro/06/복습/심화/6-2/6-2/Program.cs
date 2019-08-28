using System;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력해주세요.");

            int userInput = int.Parse(Console.ReadLine());
            if(userInput>20 && userInput%3 == 0)
            {
                Console.WriteLine("20보다 큰 3의 배수입니다.");
            }
            else
            {
                Console.WriteLine("선택한 숫자는 20보다 큰 3의 배수가 아닙니다.");
            }
        }
    }
}
