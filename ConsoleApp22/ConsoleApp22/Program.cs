using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {

        //1단계 기본함수
        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 용사님");
            Console.WriteLine("모험을 시작합니다.");
        }

        //함수 정의 : 게임시작 메시지
        static void ShowGameStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║        ⚔️ RPG 게임 시작 ⚔️        ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }

        //함수 정의: 구분선 출력
        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }
      


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //함수 호출
            ShowGameStart();
            Console.WriteLine();

            SayHello();
            PrintSeparator();

            Console.WriteLine("게임 메뉴를 불러옵니다.....");

            PrintSeparator();


            //같은 함수를 여러번 호출 가능
            Console.WriteLine("게임 종료");

            PrintSeparator();








            
          
        }

      
    }
}
