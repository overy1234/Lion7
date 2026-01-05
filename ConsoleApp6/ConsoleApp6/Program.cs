using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            //int integerNum = 10; //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수
            //double doubleNum = 3.14159; //배정밀도 실수


            //Console.WriteLine(integerNum); //출력: 10
            //Console.WriteLine(floatNum); //출력: 3.14
            //Console.WriteLine(doubleNum); //출력 : 3.14159


//            | 타입 | 크기 | 범위 | 용도 |
//| ------| ------| ------| ------|
//| byte | 1바이트 | 0 ~255 | 작은 양수(나이, 레벨) |
//| sbyte | 1바이트 | -128 ~127 | 작은 정수 |
//| short | 2바이트 | -32,768 ~32,767 | 작은 정수 |
//| ushort | 2바이트 | 0 ~65,535 | 작은 양수 |
//| int | 4바이트 | -21억 ~21억 | 가장 많이 사용 |
//| uint | 4바이트 | 0 ~42억 | 큰 양수 |
//| long | 8바이트 | 매우 큰 범위 | 아주 큰 수 |
//| ulong | 8바이트 | 0 ~아주 큰 수 | 아주 큰 양수 |
            // 게임 캐릭터 스탯
            byte level = 50;              // 레벨 (0~255면 충분)
            short attack = 1500;          // 공격력
            int gold = 1234567;           // 소지금
            long experience = 99999999L;  // 경험치 (L 접미사 필수)

            Console.WriteLine("=== 캐릭터 정보 ===");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"소지금: {gold:N0}골드");  // N0: 천 단위 구분
            Console.WriteLine($"경험치: {experience:N0}");

            // 타입별 최대값 확인
            Console.WriteLine("\n=== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            Console.WriteLine($"short 최대값: {short.MaxValue}");
            Console.WriteLine($"int 최대값: {int.MaxValue:N0}");
            Console.WriteLine($"long 최대값: {long.MaxValue:N0}");

        }
    }
}
