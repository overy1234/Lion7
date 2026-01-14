using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {

        //매개변수 int a 대신받아준다.
        static void Attack(ref int a)
        {
            Console.WriteLine("공격력 : " + a);
            a++;
           
        }



        static void Main(string[] args)
        {
            //ref 키워드 참조
            //C# 내부적으로 포인터 개발자들이 신경덜쓰게 잘만들어놓음

            int a = 10;

            Attack(ref a);

            Console.WriteLine("a 값 : " + a);


        }
    }
}
