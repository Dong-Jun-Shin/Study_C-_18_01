using System;


namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int indexNumber = 0;
            while (indexNumber < 5)
            {
                Console.Write(indexNumber);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[indexNumber] = int.Parse(Console.ReadLine());

                indexNumber = indexNumber + 1;
            }
            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");
        }
    }
}
