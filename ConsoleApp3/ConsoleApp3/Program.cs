using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////변수 선언후 값 저장
            //string greeting; //문자열 변수를 선언
            //greeting = "안녕하세요~!"; //변수에 값을 저장

            ////출력하기
            //Console.WriteLine(greeting);


            ////변수 초기화
            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; //실수형 변수 선언과 초기화
            //string city = "Seoul"; //문자열 변수 선언과 초기화

            ////변수
            //Console.WriteLine(score); //출력: 100
            //Console.WriteLine(temperature); //출력: 36.5
            //Console.WriteLine(city); //출력 : Seoul


            //방법1: 선언 후 할당 ( 두 줄)
            int health;
            health = 100;


            //방법2: 선언과 동시에 초기화 ( 한줄 ) 
            int maxHealth = 100;
            int damage = 15;

         
            //게임로직 출력
            Console.WriteLine("체력 : " + health + "/" + maxHealth);

            //데미지를 받았습니다.
            Console.WriteLine("데미지수치"+ damage);





        }
    }
}
