using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열 -> 효율적 

            ////방법 1
            //int[] scores = new int[5];   //5개의 사물함을 준비

            ////방법 2 초기값과 함께 선언
            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            ////방법 3: 간단한 초기화
            //int[] values = { 1, 2, 3, 4, 5 };

            ////4번째
            //scores[0] = 1;
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;

            //for(int i =0; i<scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}     




            ////인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];

            ////아이템 추가
            ////입력을 받아서 추가해봅시다.


            ////인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ====");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}



            ////인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];

            ////아이템 추가
            //inventory[0] = "회복 포션";
            //inventory[1] = "마나 포션";
            //inventory[2] = "강철 검";
            //inventory[3] = "가죽 갑옷";
            //inventory[4] = "마법 반지";


            ////인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ====");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}


            ////특정 아이템 사용
            //Console.WriteLine($"{inventory[0]}를 사용했습니다!");
            //inventory[0] = "(비어있음)";

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            // 플레이어 스탯 배열

            //Console.WriteLine("=== 캐릭터 스탯===");
            //int[] stats = { 100, 50, 80, 60, 45 };
            //string[] statNames = { "HP", "MP", "공격력", "방어력", "민첩" };

            //for(int i =0; i<stats.Length; i++)
            //{
            //    Console.WriteLine($"{statNames[i]}: {stats[i]}");
            //}





            //=== 캐릭터 스탯 ===
            //HP: 100
            //MP: 50
            //공격력: 80
            //방어력: 60
            //민첩: 45
            Console.OutputEncoding = Encoding.UTF8;

            //몬스터 처치 기록
            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");
            //int[] dailyKills = { 5, 3, 8, 2, 7 };
            //string[] monsterTypes = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int requiredKills = 5;

            //for(int i =0; i<dailyKills.Length; i++)
            //{
            //    string status = dailyKills[i] >= requiredKills ? "✅ 완료" : "⏳ 진행중";
            //    Console.WriteLine($"{monsterTypes[i]}: {dailyKills[i]}/{requiredKills} {status}");
            //}


            //=== 일일 퀘스트 진행도 ===
            //고블린: 5 / 5 ✅ 완료
            //오크: 3 / 5 ⏳ 진행중
            //슬라임: 8 / 5 ✅ 완료
            //드래곤: 2 / 5 ⏳ 진행중
            //좀비: 7 / 5 ✅ 완료


            //int[] scores = { 85, 92, 78, 95, 88 };

            ////배열 길이
            //Console.WriteLine("총 점수 개수: " + scores.Length);

            ////배열 순회
            //Console.WriteLine("개별 점수");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
            //}


            ////합계 계산
            //int sum = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            //Console.WriteLine($"총점 : {sum}점");
            //Console.WriteLine($"평균 : {(float)sum / (float)scores.Length}점");


            ////최고점 찾기
            //int maxScore = scores[0];

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] > maxScore)
            //    {
            //        maxScore = scores[i];
            //    }
            //}

            //Console.WriteLine($"최고점: {maxScore}점");




            ////최저점 찾기 

            //int minScore = scores[0];

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < minScore)
            //    {
            //        minScore = scores[i];
            //    }
            //}

            //Console.WriteLine($"최고점: {minScore}점");


            ////Array 클래스 메서드 활용
            //Console.WriteLine("=== Array 메서드 ===");

            ////정렬
            //int[] sortedScores = (int[])scores.Clone();  //복사본 생성
            //Array.Sort(sortedScores);
            //Console.WriteLine("정렬 후: ");

            ////for (int i = 0; i < sortedScores.Length; i++)
            ////{
            ////    Console.WriteLine(sortedScores[i]);
            ////}

            ////반복문 foreach
            //foreach(int score in sortedScores)
            //{
            //    Console.WriteLine(score);
            //}




            ////85, 92, 78, 95, 88

            ////역순정렬
            //Array.Reverse(sortedScores);
            //Console.WriteLine("역순: ");

            ////for (int i = 0; i < sortedScores.Length; i++)
            ////{
            ////    Console.WriteLine(sortedScores[i]);
            ////}

            //foreach (int score in sortedScores)
            //{
            //    Console.WriteLine(score);
            //}

            ////검색
            //int searchScore = 92;
            //int index = Array.IndexOf(scores, searchScore);
            //Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            //Console.WriteLine("찾은값 : "+scores[index]);




        }
    }
}
