using System;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총 학생 수를 입력해주세요.");
            int totalStudent = int.Parse(Console.ReadLine());
            string[] subject = { "국어", "영어", "수학" };

            int[] student = new int[totalStudent];
            int[] scores = new int[totalStudent];
            int[] totalScores = new int[totalStudent];
            int indexStudent = 0;
            int indexSubject = 0;
            

            while (indexStudent < totalStudent)
            {
                while (indexSubject < 3)
                {
                    Console.Write(indexStudent);
                    Console.Write("번째 학생의 ");
                    Console.Write(subject[indexSubject]);
                    Console.WriteLine("점수를 입력해주세요.");
                    scores[indexSubject] = int.Parse(Console.ReadLine());

                    totalScores[indexStudent] = totalScores[indexStudent] + scores[indexSubject];
                    indexSubject = indexSubject + 1;
                }
                Console.WriteLine("**************************************");
                Console.Write(indexStudent);
                Console.WriteLine("번째 학생의 입력이 끝났습니다.");
                Console.WriteLine("**************************************");
                Console.WriteLine("");

                indexSubject = 0;
                indexStudent = indexStudent + 1;                
            }
            Console.WriteLine("");
            Console.WriteLine("");
            indexStudent = 0;

            Console.WriteLine("각 학생의 총점과 평균은 다음과 같습니다.");
            Console.WriteLine("------------------------------------------");

            while (indexStudent < totalStudent)
            {
                Console.Write(indexStudent);
                Console.WriteLine("번째 학생");
                Console.Write("총점: ");
                Console.WriteLine(totalScores[indexStudent]);
                Console.Write("평균: ");
                Console.WriteLine(totalScores[indexStudent] / 3);
                Console.WriteLine("");

                indexStudent = indexStudent + 1;
            }

        }
    }
}
