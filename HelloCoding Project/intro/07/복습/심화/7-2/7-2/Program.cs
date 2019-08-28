using System;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
            double[] scores = new double[5];

            Console.Write(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[0] = double.Parse(Console.ReadLine());

            Console.Write(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[1] = double.Parse(Console.ReadLine());

            Console.Write(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[2] = double.Parse(Console.ReadLine());

            Console.Write(subjects[3]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[3] = double.Parse(Console.ReadLine());

            Console.Write(subjects[4]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[4] = double.Parse(Console.ReadLine());

            if (!(scores[0] >= 0 && scores[0] <= 100 && scores[1] >= 0 && scores[1] <= 100 &&
                scores[2] >= 0 && scores[2] <= 100 && scores[3] >= 0 && scores[3] <= 100 &&
                scores[4] >= 0 && scores[4] <= 100))
            {
                Console.WriteLine("점수는 0 ~ 100 사이로 입력해주세요");
            }
            else
            {
                double totalScore = scores[0] + scores[1] + scores[2] + scores[3] + scores[4];

                Console.Write("총점: ");
                Console.WriteLine(totalScore);

                Console.Write("평균: ");
                Console.WriteLine(totalScore / 5);
            }
        }
    }
}
