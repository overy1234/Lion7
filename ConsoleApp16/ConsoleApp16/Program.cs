using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;

            //while(i < 5)
            //{                
            //    Console.WriteLine(i);
            //    i++; //증감
            //}


            //// ==========================================
            //// 예제 2: 10부터 1까지 카운트다운
            //// ==========================================
            //Console.WriteLine("\n=== 예제 2: 카운트다운 ===");
            //int countdown = 10;

            //while(countdown > 0)
            //{
            //    Console.WriteLine(countdown);
            //    countdown--;
            //}

            // ==========================================
            // 예제 3: 합계 구하기 (1+2+3+4+5)
            // ==========================================
            //Console.WriteLine("\n=== 예제 3: 합계 구하기 ===");
            //int sum = 0;
            //int i = 1;

            //while( i <= 5)
            //{
            //    sum = sum + i;  // sum += i;
            //    Console.WriteLine(sum);
            //    i++;
            //}
            Console.OutputEncoding = Encoding.UTF8;
            // ==========================================
            // 예제 4: 특정 값까지 반복
            // ==========================================
            //Console.WriteLine("\n=== 예제 4: 목표 달성하기 ===");
            //int coins = 0;
            //int target = 50;
            //int day = 0;

            //while (coins < target)
            //{
            //    day++;
            //    coins += 10;  // 하루에 10코인씩
            //    Console.WriteLine($"{day}일차: 코인 {coins}개");
            //}
            //Console.WriteLine($"🎉 목표 달성! {day}일 걸렸습니다.");


            //do-while

            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한번 실행됩니다.");
            //    x--;

            //} while (x > 0);


            //string choice;
            //int totalPrice = 0;

            //do
            //{
            //    //메뉴출력
            //    Console.WriteLine("메뉴판");
            //    Console.WriteLine("1. 짜장면 - 5,000원");
            //    Console.WriteLine("2. 짬뽕 - 6,000원");
            //    Console.WriteLine("3. 탕수육 - 15,000원");
            //    Console.WriteLine("4. 볶음밥 - 7,000원");
            //    Console.WriteLine("0. 주문 완료");
            //    Console.WriteLine("=========================");
            //    Console.Write("메뉴 번호를 선택하세요: ");

            //    choice = Console.ReadLine();

            //    //메뉴 선택 처리
            //    switch(choice)
            //    {
            //        case "1":
            //            Console.WriteLine("짜장면 추가! (+5,000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "2":
            //            Console.WriteLine("짜장면 추가! (+6,000원)");
            //            totalPrice += 6000;
            //            break;
            //        case "3":
            //            Console.WriteLine("짜장면 추가! (+15,000원)");
            //            totalPrice += 15000;
            //            break;
            //        case "4":
            //            Console.WriteLine("짜장면 추가! (+7,000원)");
            //            totalPrice += 7000;
            //            break;
            //        case "0":
            //            Console.WriteLine("주문을 완료합니다.");
            //            break;
            //        default:
            //            Console.WriteLine("잘못된 선택입니다.");
            //            break;
            //    }

            //    //0번 선택 전까지
            //    if(choice != "0")
            //    {
            //        Console.WriteLine($"현재 총액: {totalPrice:N0}원");
            //    }



            //} while (choice != "0"); //0을 입력할 때까지 반복


            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //        continue;

            //    Console.WriteLine(i);
            //}

            //int n = 1;

            //천마귀환:

            //if(n <= 5)
            //{
            //    goto 천마강림;
            //    Console.WriteLine(n);
            //    n++;
            //    goto 천마귀환; //레이블로 이동
            //}


            //천마강림:
            //Console.WriteLine("천마강림하셨습니다.");








        }
    }
}
