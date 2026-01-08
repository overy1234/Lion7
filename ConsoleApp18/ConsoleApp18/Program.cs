using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int targetX = 50;
            const int targetY = 20;

            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정 (가능 80, 세로 25)
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.OutputEncoding = Encoding.UTF8;
            int px = 10, py = 10;
            

            ConsoleKeyInfo keyInfo; //키관련된 정보

            Console.CursorVisible = false;

            while(true)
            {
                Console.Clear();  //화면지우기

                Console.SetCursorPosition(px, py); //좌표

                Console.Write("●"); //현재 위치 출력

                Console.SetCursorPosition(targetX, targetY);
                Console.Write("🏠");

                if(px == targetX && py == targetY)
                {

                    Console.Clear();
                    Console.CursorVisible = false;  // 커서 숨기기

                    int width = 80;
                    int height = 25;
                    int centerX = width / 2;
                    int centerY = height / 2;

                    //Console.WriteLine("=== 콘솔 파동 효과 (80x25) ===");
                    //Console.WriteLine("Press any key to start...");
                    //Console.ReadKey(true);

                    // ==========================================
                    // 예제 1: 사각형 파동 (확장)
                    // ==========================================
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    //Console.WriteLine("=== 사각형 파동 확장 ===");

                    int maxDistance = Math.Max(centerX, centerY);

                    for (int distance = 0; distance <= maxDistance; distance++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                int distFromCenter = Math.Max(
                                    Math.Abs(x - centerX),
                                    Math.Abs(y - centerY)
                                );

                                if (distFromCenter == distance)
                                {
                                    Console.SetCursorPosition(x, y);
                                    Console.Write("■");
                                }
                            }
                        }

                        Thread.Sleep(50);  // 0.05초 대기
                    }

                    Thread.Sleep(500);









                    Console.Clear();
                    Random rand = new Random();
                    for (int frame = 0; frame < 5; frame++)
                    {
                        Console.Clear();

                        ConsoleColor color = frame % 2 == 0 ? ConsoleColor.Yellow : ConsoleColor.Red;
                        Console.ForegroundColor = color;

                        Console.SetCursorPosition(25, 8);
                        Console.WriteLine("╔═══════════════════════════════╗");
                        Console.SetCursorPosition(25, 9);
                        Console.WriteLine("║                               ║");
                        Console.SetCursorPosition(25, 10);
                        Console.WriteLine("║  ⚒️   대장장이 키우기   ⚒️    ║");
                        Console.SetCursorPosition(25, 11);
                        Console.WriteLine("║                               ║");
                        Console.SetCursorPosition(25, 12);
                        Console.WriteLine("╚═══════════════════════════════╝");

                        System.Threading.Thread.Sleep(500);
                    }
                    Console.ResetColor();

                    int pmoney = 100;
                    int input;
                    int rnd;

                    Thread.Sleep(500);


                    //무한반복
                    while (true)
                    {
                        Console.Clear(); //화면지우기
                        Console.WriteLine("1. 나무캐기 ");
                        Console.WriteLine("2. 장비뽑기 ");
                        Console.WriteLine("3. 나가기 ");
                        Console.Write("입력 : ");
                        input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

                        if (input == 1) //나무캐기화면
                        {
                            while (true)
                            {
                                Console.WriteLine("나무캐기(엔터)");
                                Console.WriteLine("뒤로가기 x");

                                string str = Console.ReadLine();

                                pmoney += 100;
                                Console.WriteLine("소지금 : " + pmoney);
                                if (str == "x")
                                {
                                    Console.WriteLine("뒤로가기");
                                    break;
                                }


                            }
                        }
                        else if (input == 2)
                        {
                            //장비뽑기
                            if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
                            {
                                pmoney -= 1000;

                                //20번 뽑기
                                for (int i = 1; i <= 20; i++)
                                {
                                    rnd = rand.Next(1, 101);

                                    if (rnd == 1) // 1퍼
                                    {
                                        Console.WriteLine("도끼등급 SSS");
                                    }
                                    else if (rnd >= 2 && rnd <= 6)
                                    {
                                        Console.WriteLine("도끼등급 SS");
                                    }
                                    else if (rnd >= 7 && rnd <= 17)
                                    {
                                        Console.WriteLine("도끼등급 S");
                                    }
                                    else if (rnd >= 18 && rnd <= 38)
                                    {
                                        Console.WriteLine("도끼등급 A");
                                    }
                                    else if (rnd >= 39 && rnd <= 69)
                                    {
                                        Console.WriteLine("도끼등급 B");
                                    }
                                    else
                                    {
                                        Console.WriteLine("도끼등급 C");
                                    }
                                    Thread.Sleep(500); //0.5초정도로 뽑혀라.

                                }


                            }
                            else
                            {
                                Console.WriteLine("돈이 부족합니다. \n");
                                Thread.Sleep(1000);
                            }
                        }
                        else if (input == 3)
                        {
                            Console.WriteLine("게임을 나갑니다.");
                            Environment.Exit(0);
                        }
                    }
                }
                

 


                keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 x)

                //방향키 입력에 따른 좌표 변경
                switch(keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:  if (py > 0)  py--;  break;
                    case ConsoleKey.DownArrow: if (py < Console.WindowHeight - 1) py++; break;
                    case ConsoleKey.LeftArrow: if (px > 0) px--; break;
                    case ConsoleKey.RightArrow: if (px < Console.WindowWidth - 1) px++; break;
                    case ConsoleKey.Spacebar:  Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: break; //ESC키로 탈출

                }
            }     

        }
    }
}
