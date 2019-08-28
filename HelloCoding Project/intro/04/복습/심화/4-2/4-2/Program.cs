using System;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainCoin = 10;
            remainCoin = remainCoin / 2;
            remainCoin = remainCoin + 1;

            int aramCoin = 10 - remainCoin;

            remainCoin = remainCoin / 2;
            remainCoin = remainCoin - 2;

            int uramCoin = 10 - aramCoin - remainCoin;

            Console.Write("아람이가 가져간 동전개수: ");
            Console.WriteLine(aramCoin);
            Console.Write("우람이가 가져간 동전개수: ");
            Console.WriteLine(uramCoin);
            Console.Write("남는 동전개수: ");
            Console.WriteLine(remainCoin);


            // 변수를 1개로 하는 방법과 2개로 하는 방법이 있다.
        }
    }
}
