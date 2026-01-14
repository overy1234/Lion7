using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        //일반함수
        static void Swap1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            
        }

        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
          

            //swap 두개의 변수의 값을 바꿔주기
            Swap(ref x, ref y);

            Console.WriteLine("x : " + x + " y : " + y);
            
        }
    }
}
