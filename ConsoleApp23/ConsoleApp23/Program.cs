using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        //int넘겨보기   2매개변수 입력쪽활용
        //static void Attack(int att,int def)
        //{
        //    Console.WriteLine("공격력 전달받았다. : " + att);
        //    Console.WriteLine("방어력 : " + def);
        //}

        //함수로만들기
        //플레이어이름 : 
        //공격력 : 
        //방어력 : 
        //민첩   :
        //운     :


        static void PlayerInfo(string playerName, int att,int def, int dex, int luck)
        {
            Console.WriteLine("플레이어이름 : " + playerName);
            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("방어력 : " + def);
            Console.WriteLine("민첩   : " + dex);
            Console.WriteLine("운     : " + luck);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("플레이어 정보입니다.");

            PlayerInfo("카타나",10,20,30,40);

        }
    }
}
