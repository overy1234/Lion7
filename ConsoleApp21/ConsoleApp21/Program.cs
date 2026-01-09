using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)


            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //배열 문자열로 그리기


            int playerX = 0;
            int playerY = 12;


            ConsoleKeyInfo keyInfo;  //키정보

            Console.CursorVisible = false; //콘솔창 커서 안보이게하기

            //Sleep()  //1000 1초동안 프로그램을 잠시멈춤 
            //지연방법 시간을 계산해서 1초 루프
            int dwTime = Environment.TickCount;   // 1/1000 초가 흐릅니다.

           



            while (true)
            {
                //1초루프
                if(dwTime + 10 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    //키역영
                    int pressKey; //정수형 변수 선언 키값 받을거임

                    if(Console.KeyAvailable) //키가 눌렸는지 체크
                    {
                        pressKey = _getch(); //요렇게 하면
                        if (pressKey == 224)
                            pressKey = _getch(); //요렇게 하면


                        switch (pressKey)
                        {
                           
                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: //스페이스바
                                //-> 미사일 날라가기
                                break;
                        }


                    }


                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                }

             
            }

        }
    }
}
