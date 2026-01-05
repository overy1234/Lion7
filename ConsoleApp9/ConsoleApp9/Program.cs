using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //이 함수는 1000 1초
            // 1/1000
            //Console.WriteLine("안");
            //Thread.Sleep(1000); //1초 슬립 프로그램 멈춤
            //Console.Clear(); //콘솔내용 한번싹지움
            //Console.WriteLine("안녕");
            //Thread.Sleep(1000);
            //Console.Clear(); //콘솔내용 한번싹지움
            //Console.WriteLine("안녕하");
            //Thread.Sleep(1000);
            //Console.Clear(); //콘솔내용 한번싹지움
            //Console.WriteLine("안녕하세");
            //Thread.Sleep(1000);
            //Console.Clear(); //콘솔내용 한번싹지움
            //Console.WriteLine("안녕하세요");
            //Thread.Sleep(1000);
            //Console.Clear(); //콘솔내용 한번싹지움


            //과제
            //저번시간 만들었던 UI 하나정해서 
            //비주얼하게 만들어보세요.
            //자유롭게 만들어보시오.

            //로딩중
            Console.WriteLine("로딩중....");
            Console.Write("진행률 : [");
            Console.Write("■");
            Thread.Sleep(500);    
            
            Console.Write("■");
            Thread.Sleep(500);    
            
            Console.Write("■");
            Thread.Sleep(500);   
            
            Console.Write("■");
            Thread.Sleep(500);
            
            Console.Write("■");
            Thread.Sleep(500);
            
            Console.Write("■");
            Thread.Sleep(500);
           
            Console.Write("■");
            Thread.Sleep(500);
          
            Console.Write("■");
            Thread.Sleep(500);
           
            Console.Write("■");
            Thread.Sleep(500);
        
            Console.Write("] 100% \n");

            //참고~!
        }
    }
}
