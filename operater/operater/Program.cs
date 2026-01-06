using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연산자
            //int a = 5, b = 3;
            //int sum = a + b; //산술연산자 사용 +
            //bool isEqual = (a == b); //관계형 연산자 사용

            //Console.WriteLine($"합 : {sum}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");

            //단항 연산자
            //int number = 5;
            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //bool flag = true;
            //Console.WriteLine(!flag); //논리 부정 : 반대로 바꿔준다. true false


            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            int a = 5;
            int b = 4;
            

            a = a + b;
            Console.WriteLine("합계 : " + a);
            a = 5;
            a = a - b;
            Console.WriteLine("합계 : " + a);
            a = 5;
            a = a * b;
            Console.WriteLine("합계 : " + a);
            a = 5;
            a = a / b;
            Console.WriteLine("합계 : " + a);
            //할당 연산자
            a = 5;
            a += b;
          
            Console.WriteLine("합계 : " + a);
            //-
            a = 5;
            a -= b;
         
            Console.WriteLine("합계 : " + a);
            //*
            a = 5;
            a *= b;
          
            Console.WriteLine("합계 : " + a);
            // /
            a = 5;
            a /= b;
           
            Console.WriteLine("합계 : " + a);
            //%
            a = 5;
            a %= b;
          
            Console.WriteLine("합계 : " + a);

        }
    }
}
