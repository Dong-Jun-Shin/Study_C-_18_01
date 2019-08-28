using System;

namespace _9_2_R.S.P_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("      가위, 바위, 보 게임입니다.        ");
            Console.WriteLine("                                        ");
            Console.WriteLine("             유명합니다.                ");
            Console.WriteLine("     그러므로 설명은 생략합니다.        ");
            Console.WriteLine("              이기세요.                 ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("  1은 \"가위\", 2는 \"바위\", 3은 \"보\"입니다.     ");
            Console.WriteLine();
            Console.WriteLine();

            string[] select = { "가위", "바위", "보" };

            while (true)
            {
                Random random = new Random();
                int D_SelNum = random.Next(1, 4);
                Console.WriteLine("상대방이 낼 것을 정했습니다.");
                Console.WriteLine();

                Console.WriteLine("당신이 낼 것을 골라주세요. ");
                int A_SelNum = int.Parse(Console.ReadLine());

                if (A_SelNum < 1 || A_SelNum > 3)
                {
                    Console.WriteLine("1은 \"가위\", 2는 \"바위\", 3은 \"보\"입니다. ");
                    Console.WriteLine("1 ~ 3 사이의 숫자를 입력해주세요.");
                }
                else
                {
                    if (D_SelNum == A_SelNum)
                    {
                        Console.WriteLine();
                        Console.Write("상대방이 낸 것 : (");
                        Console.Write(D_SelNum);
                        Console.Write(") ");
                        Console.WriteLine(select[D_SelNum-1]);

                        Console.Write("당신이 낸 것 : (");
                        Console.Write(A_SelNum);
                        Console.Write(") ");
                        Console.WriteLine(select[A_SelNum-1]);

                        Console.WriteLine();
                        Console.WriteLine("비겼습니다. 다시 선택해주세요.");
                        Console.WriteLine("-----------------------------------");
                    }
                    else if (D_SelNum < A_SelNum)
                    {
                        if (D_SelNum == 1 && A_SelNum == 3)
                        {
                            Console.WriteLine();
                            Console.Write("상대방이 낸 것 : (");
                            Console.Write(D_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[D_SelNum-1]);

                            Console.Write("당신이 낸 것 : (");
                            Console.Write(A_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[A_SelNum-1]);

                            Console.WriteLine();
                            Console.WriteLine("당신이 졌습니다.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("상대방이 낸 것 : (");
                            Console.Write(D_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[D_SelNum-1]);

                            Console.Write("당신이 낸 것 : (");
                            Console.Write(A_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[A_SelNum-1]);

                            Console.WriteLine();
                            Console.WriteLine("당신이 이겼습니다.");
                            break;
                        }
                    }
                    else if (D_SelNum > A_SelNum)
                    {
                        if (D_SelNum == 3 && A_SelNum == 1)
                        {
                            Console.WriteLine();
                            Console.Write("상대방이 낸 것 : (");
                            Console.Write(D_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[D_SelNum-1]);

                            Console.Write("당신이 낸 것 : (");
                            Console.Write(A_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[A_SelNum-1]);

                            Console.WriteLine();
                            Console.WriteLine("당신이 이겼습니다.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("상대방이 낸 것 : (");
                            Console.Write(D_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[D_SelNum-1]);

                            Console.Write("당신이 낸 것 : (");
                            Console.Write(A_SelNum);
                            Console.Write(") ");
                            Console.WriteLine(select[A_SelNum-1]);

                            Console.WriteLine();
                            Console.WriteLine("당신이 졌습니다.");
                            break;
                        }
                    }
                }
            }
        }
    }
}
