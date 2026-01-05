using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미합니다.
            //int number = 10;  //정수형 리터럴
            //double pi = 3.14; //실수형 리터럴
            //char letter = 'A'; //문자 리터럴
            //string name = "Alice"; //문자열 리터럴

            //Console.WriteLine(number); //출력: 10
            //Console.WriteLine(pi);     //출력: 3.14
            //Console.WriteLine(letter); //출력: A
            //Console.WriteLine(name);   //출력: Alice


            //리터럴 연습
            //플레이스코어 100
            //파이 3.14
            //등급 'A'
            //플레이어이름 홍길동

            //결과 출력하기

            // 정수 리터럴
            int playerScore = 100;        // 100이 정수 리터럴

            // 실수 리터럴
            double pi = 3.14;             // 3.14가 실수 리터럴

            // 문자 리터럴 (작은따옴표)
            char grade = 'A';             // 'A'가 문자 리터럴

            // 문자열 리터럴 (큰따옴표)
            string playerName = "홍길동";  // "홍길동"이 문자열 리터럴

            // 논리 리터럴
            bool isGameOver = false;      // false가 논리 리터럴

            // 결과 출력
            Console.WriteLine("플레이어: " + playerName);
            Console.WriteLine("점수: " + playerScore);
            Console.WriteLine("등급: " + grade);
            Console.WriteLine("파이 값: " + pi);
            Console.WriteLine("게임오버: " + isGameOver);

        }
    }
}
