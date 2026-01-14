using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        //반환값이 있는함수 3단계

        //정수반환
        static int GetNumber() //정수반환
        {
            return 42;
        }
        //문자열반환 2단계 입력 / 반환
        static string ConnectMessage(string name)
        {
            return name + "님 접속하셨습니다.";
        }

       

        static void Main(string[] args)
        {
          //  int num = GetNumber();

           // Console.WriteLine("숫자 반환 : " + num);

            string cm = ConnectMessage("천마");

            Console.WriteLine(cm);



        }
    }
}
