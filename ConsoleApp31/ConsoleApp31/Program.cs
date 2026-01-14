using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        //전역변수
        static int HP = 100;

       //1부터 n까지의 합 구하기
        //static int SumToN(int n)
        //{
        //    if (n<=0)
        //    {
        //        return 0;
        //    }

        //    return n + SumToN(n - 1); //n+ (n-1까지의 합)
         
        //}
        static void Attack()
        {
            HP--;
        }


        static void Main(string[] args)
        {
            //1부터 n까지의 합 구하기
            // int sum = SumToN(10);

            //Console.WriteLine("1+2....10 = " + sum);
            Attack();
            Console.WriteLine("HP : " + HP);
           
        }
    }
}
