using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //다차원배열 
            // #### 배열 크기 확인

            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2


            //=== 좌석 배치도 ===

            //[A1][A2][A3]
            //[B1][B2][B3]
            //[C1][C2][C3]

            //3 x 3 좌석 배치도
            //string[,] seats = new string[3, 3]
            //{
            //   { "A1","A2","A3"},
            //   { "B1","B2","B3"},
            //   { "C1","C2","C3"}
            //};

            //Console.WriteLine("=== 좌석 배치도 ===");


            ////행(row) 반복
            //for(int row = 0; row <seats.GetLength(0); row++)
            //{
            //    //열(column) 반복
            //    for(int col =0; col<seats.GetLength(1); col++)
            //    {
            //        Console.Write($"[{seats[row, col]}]");
            //    }
            //    Console.WriteLine(); //줄바꿈
            //}


            ////첫 번째 좌석: A1
            ////중앙 좌석: B2
            ////마지막 좌석: C3
            //Console.WriteLine("첫 번째 좌석: " + seats[0, 0]);
            //Console.WriteLine("중앙 좌석: " + seats[1, 1]);
            //Console.WriteLine("마지막 좌석: " + seats[2, 2]);


            //2D 게임맵
            //int[,] map = new int[5, 5]
            //{
            //    { 0,0,1,0,0},
            //    { 0,2,1,0,3},
            //    { 0,0,1,0,0},
            //    { 1,1,1,0,0},
            //    { 0,0,0,0,9},
            //};

            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
            //Console.OutputEncoding = Encoding.UTF8;

            ////맵 출력
            //for (int y =0; y<map.GetLength(0); y++)
            //{
            //    for(int x=0; x< map.GetLength(1); x++)
            //    {
            //        switch (map[y, x]) 
            //        { 
            //            case 0:
            //                Console.Write("⬜ ");
            //                break;
            //            case 1:
            //                Console.Write("⬛ ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💎 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}



            // 학생 3명, 과목 4개 (국어, 영어, 수학, 과학)
            //int[,] scores = new int[3, 4]
            //{
            //{ 85, 90, 88, 92 },  // 학생 1
            //{ 78, 85, 90, 87 },  // 학생 2
            //{ 92, 88, 95, 90 }   // 학생 3
            //};

            //string[] students = { "김철수", "이영희", "박민수" };
            //string[] subjects = { "국어", "영어", "수학", "과학" };

            //Console.WriteLine("=== 성적표 ===\n");

            //// 헤더 출력
            //Console.Write("이름\t");
            //foreach (string subject in subjects)
            //{
            //    Console.Write($"{subject}\t");
            //}
            //Console.WriteLine("평균");
            //Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            //// 학생별 성적 출력
            //for (int i = 0; i < scores.GetLength(0); i++)
            //{
            //    Console.Write($"{students[i]}\t");

            //    int sum = 0;
            //    for (int j = 0; j < scores.GetLength(1); j++)
            //    {
            //        Console.Write($"{scores[i, j]}\t");
            //        sum += scores[i, j];
            //    }

            //    double average = (double)sum / scores.GetLength(1);
            //    Console.WriteLine($"{average:F1}");
            //}

            //// 과목별 평균
            //Console.WriteLine("\n=== 과목별 평균 ===");
            //for (int subject = 0; subject < scores.GetLength(1); subject++)
            //{
            //    int sum = 0;
            //    for (int student = 0; student < scores.GetLength(0); student++)
            //    {
            //        sum += scores[student, subject];
            //    }
            //    double avg = (double)sum / scores.GetLength(0);
            //    Console.WriteLine($"{subjects[subject]}: {avg:F1}점");
            //}


            // 가변 배열
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };  //4명
            //raid[1] = new string[] { "도적", "전사", "힐러" };            //3명
            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" }; //5명

            //Console.WriteLine("=== 레이드 파티 구성 ===");
            //for(int i =0; i< raid.Length; i++)
            //{
            //    Console.WriteLine($"파티 {i + 1} ({raid[i].Length}명):");
            //    for(int j=0; j< raid[i].Length; j++)
            //    {
            //        Console.WriteLine($" - {raid[i][j]}");
            //    }
            //}


            //동적배열
            //            List<T> 컬렉션 완벽 가이드
            //🎯 List<T> 란?
            //**List < T > **는 C#에서 가장 많이 사용되는 동적 배열(Dynamic Array) 컬렉션입니다.

            //T는 제네릭 타입 매개변수로, 저장할 데이터 타입을 지정합니다
            //크기가 자동으로 조절됩니다
            //System.Collections.Generic 네임스페이스에 포함

            // 선언 방법
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };
            //List<string> items = new List<string>();

            //// Add: 끝에 추가
            //items.Add("회복 포션");
            //items.Add("마나 포션");

            //List 생성
            //List<string> inventory = new List<string>();

            //Console.WriteLine("=== 도적 인벤토리 시스템 ==");

            ////아이템 추가 (Add)
            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");
            //Console.WriteLine("아이템 3개 추가");

            ////현재 인벤토리
            //Console.WriteLine($"인벤토리 ({inventory.Count}개):");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}
            //Console.WriteLine();
            //inventory[0] = "초록포션";

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}
            //Console.WriteLine();
            ////특정 위치에 추가 (Insert)
            //inventory.Insert(1, "전설 검");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            ////아이템 제거 (Remove)
            //inventory.Remove("초록포션");
            //Console.WriteLine();

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            ////인덱스로 제거 (RemoveAt)
            //inventory.RemoveAt(0);
            //Console.WriteLine();
            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Dictionary<string, int> stats = new Dictionary<string, int>();

            ////데이터추가
            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);


            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //foreach(KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            ////키 존재 확인
            //string searchStat = "방어력";

            //if(stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(stats[searchStat]);
            //}
            //else
            //{
            //    Console.WriteLine("해당스탯이 없습니다.");
            //}


            //딕셔너리 컬렉션을 이용해서 구현해보시오.
            //=== 상점 아이템 ===
            //회복 포션: 50골드
            //마나 포션: 40골드
            //강철 검: 500골드
            //가죽 갑옷: 300골드
            //마법 반지: 1000골드

            //✅ '강철 검' 구매 성공!
            //남은 골드: 100





        }
    }
}
