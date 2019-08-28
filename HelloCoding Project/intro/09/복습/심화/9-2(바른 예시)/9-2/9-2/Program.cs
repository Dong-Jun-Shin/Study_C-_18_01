using System;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" 학급별 성적 평균을 구하는 프로그램입니다. ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("반이 몇개 있습니까?");
            int C_Numbers = int.Parse(Console.ReadLine());

            Console.WriteLine("한 반의 학생이 몇명 입니까?");
            int S_Numbers = int.Parse(Console.ReadLine());

            int[] S_Scores = new int[S_Numbers];
            int[] C_Total = new int[C_Numbers];

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" 이제 해당 학생들의 성적을 입력해주세요 ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            for (int C_Count = 0; C_Count < C_Numbers; C_Count++)
            {
                for (int S_Count = 0; S_Count < S_Numbers; S_Count++)
                {
                    Console.Write(C_Count);
                    Console.Write("반 ");
                    Console.Write(S_Count);
                    Console.WriteLine("번째 학생의 성적을 입력해주세요.");

                    S_Scores[S_Count] = int.Parse(Console.ReadLine());
                }

                for (int S_Count = 0; S_Count < S_Numbers; S_Count++)
                {
                    C_Total[C_Count] = C_Total[C_Count] + S_Scores[S_Count];
                }

                C_Total[C_Count] = C_Total[C_Count] / S_Numbers;
            }

            for (int C_Count = 0; C_Count < C_Numbers; C_Count++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------");
                Console.Write(C_Count);
                Console.Write("반 성적 평균은 ");
                Console.Write(C_Total[C_Count]);
                Console.Write("점 입니다.");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}