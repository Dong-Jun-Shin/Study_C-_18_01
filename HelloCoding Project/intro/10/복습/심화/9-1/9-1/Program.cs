using System;

namespace _9_1_Select_Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                    숫자 맞추기 게임                   ");
            Console.WriteLine("");
            Console.WriteLine("1. 수비수가 1 이상 100 이하의 숫자를 무작위로 고릅니다.");
            Console.WriteLine("2. 공격수가 숫자를 입력합니다.");
            Console.WriteLine("3. 일반적인 규칙은 \"업다운게임\"과 동일합니다.");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");

            Random random = new Random();
            int D_SelNum = random.Next(1, 101);
            Console.WriteLine("수비수가 숫자를 골랐습니다.");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("공격수의 차례입니다. 숫자를 골라주세요. ");
                int A_SelNum = int.Parse(Console.ReadLine());

                if (A_SelNum > 100 || A_SelNum < 1)
                {
                    Console.WriteLine("1 ~ 100 사이의 숫자를 골라주세요.");
                }
                else
                {
                    if (D_SelNum == A_SelNum)
                    {
                        Console.WriteLine("정답입니다!");
                        break;
                    }
                    else if (D_SelNum < A_SelNum)
                    {
                        Console.WriteLine("더 작은 숫자입니다.");
                    }
                    else if (D_SelNum > A_SelNum)
                    {
                        Console.WriteLine("더 큰 숫자입니다. ");
                    }
                }
            }
        }
    }
}
