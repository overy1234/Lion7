using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //for (int i =0; i < 5; i++)
            //{
            //    Console.WriteLine("천마연산신공"); //엄청길게 캐스팅해야하는 구절
            //}

            // 몬스터 생성
            //Console.WriteLine("=== 몬스터 웨이브 시작 ===");
            //int waveMonsterCount = 5;

            //for (int i = 1; i <= waveMonsterCount; i++)
            //{
            //    Console.WriteLine($"👹 고블린 #{i} 생성!");
            //}

            //Console.WriteLine($"총 {waveMonsterCount}마리 생성 완료!\n");

            //=== 몬스터 웨이브 시작 ===
            //👹 고블린 #1 생성!
            //👹 고블린 #2 생성!
            //👹 고블린 #3 생성!
            //👹 고블린 #4 생성!
            //👹 고블린 #5 생성!
            //총 5마리 생성 완료!
            Console.OutputEncoding = Encoding.UTF8;

            //=== 게임 시작 카운트다운 ===
            //5...
            //4...
            //3...
            //2...
            //1...
            //🎮 게임 시작!
            // 카운트다운
            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //for (int count = 5; count >= 1; count--)
            //{
            //    Console.WriteLine($"{count}...");
            //}
            //Console.WriteLine("🎮 게임 시작!\n");


            //for( ; ; )
            //{
            //    Console.WriteLine("무한반복");
            //    Thread.Sleep(1000);
            //}

            //랜덤함수
            //게임에서 굉장히 중요한 기능이다.

            ////Random 객체 생성
            //Random random = new Random(); //랜덤함수 사용방법


            ////사용방법
            //int number = random.Next(1, 7); //1~6까지 주사위



            //검 종류
            //무한의 대검  10 %
            //카타나       20 %
            //엑스칼리버   30  %
            //정기정검     40  %
            


            string sword = "무한의 대검";

            Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");
                        
            Random rand = new Random();

            int random = 0;

            for(int i=0; i<20; i++)
            {
                random = rand.Next(1,101);

                if(random >=1 &&  random <=10)
                {
                    sword = "무한의 대검";
                }
                else if (random >= 11 && random <= 30)
                {
                    sword = "카타나";
                }
                else if (random >= 31 && random <= 60)
                {
                    sword = "엑스칼리버";
                }
                else if (random >= 61 && random <= 100)
                {
                    sword = "정기정검";
                }

                Console.WriteLine(sword);
                Thread.Sleep(500);
            }

            //랜덤 for문까지함

        }
    }
}
