using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2차원 for문
            //for(int i =1; i<=3; i++)
            //{
            //    for(int j=1; j<=3; j++)
            //    {
            //        Console.WriteLine($"i:{i} j:{j}");
            //    }
            //    Console.WriteLine();
            //}

            Console.OutputEncoding = Encoding.UTF8;

            //=== 예제 1: 사각형 그리기 ===
            //⬜ ⬜ ⬜ 
            //⬜ ⬜ ⬜ 
            //⬜ ⬜ ⬜ 

            //Console.WriteLine("=== 예제 1: 사각형 그리기 ===");

            //for (int row = 0; row < 3; row++)  // 행(가로줄) 3번
            //{
            //    for (int col = 0; col < 3; col++)  // 열(세로줄) 3번
            //    {
            //        Console.Write("⬜ ");
            //    }
            //    Console.WriteLine();  // 한 줄 끝나면 줄바꿈
            //}


            //=== 예제 2: 숫자 표 ===
            //1 2 3
            //1 2 3
            //1 2 3

            // ==========================================
            // 예제 2: 숫자 표 만들기
            // ==========================================
            //Console.WriteLine("\n=== 예제 2: 숫자 표 ===");

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{j} ");
            //    }
            //    Console.WriteLine();
            //}


            //=== 예제 3: 좌표 찍기 ===
            //(0, 0)(1, 0)(2, 0)
            //(0, 1)(1, 1)(2, 1)
            //(0, 2)(1, 2)(2, 2)

            //Console.WriteLine("\n=== 예제 3: 좌표 찍기 ===");

            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        Console.Write($"({x},{y}) ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i= 0; i<5; i++)
            //{
            //    for(int j =0; j<5; j++)
            //    {
            //        if(j <= i)
            //        {
            //            Console.Write("*");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j >= i)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.WriteLine();
            //}


            //=== 예제 6:  곱셈표 ===
            //1×1 = 1  1×2 = 2  1×3 = 3
            //2×1 = 2  2×2 = 4  2×3 = 6
            //3×1 = 3  3×2 = 6  3×3 = 9

            //=== 예제 9: 미니 게임 맵 ===
            //🏠 🟩 🟩 🟩 
            //🟩 🟩 🟩 🟩 
            //🟩 🟩 🟩 🟩 
            //🟩 🟩 🟩 🎯 
            //Console.WriteLine("\n=== 예제 9: 미니 게임 맵 ===");

            //for (int y = 0; y < 4; y++)
            //{
            //    for (int x = 0; x < 4; x++)
            //    {
            //        if (x == 0 && y == 0)
            //            Console.Write("🏠 ");  // 시작점
            //        else if (x == 3 && y == 3)
            //            Console.Write("🎯 ");  // 목표
            //        else
            //            Console.Write("🟩 ");  // 길
            //    }
            //    Console.WriteLine();
            //}




        }
    }
}
