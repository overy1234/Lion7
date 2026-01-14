using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        //2단계활용
        static void GreetPlayer(string playerName)
        {
            Console.WriteLine($"환영합니다. {playerName}님!");
        }

        static void ShowPlayerInfo(string job, int level)
        {
            Console.WriteLine($"직업 : {job}");
            Console.WriteLine($"레벨 : {level}");
        }


        //매개변수 3개 체력바 출력
        static void DrawHealthBar(int current, int max, int barLength)
        {
            Console.Write("HP [");

            int filledLength = (int)((double)current / max * barLength);

            for(int i =0; i<barLength; i++)
            {
                if (i < filledLength)
                    Console.Write("■");
                else
                    Console.Write("□");
            }

            Console.WriteLine($"] {current}/{max}");
        }

        //데미지 계산 출력
        static void ShowDamage(string attacker, string target, int damage)
        {
            Console.WriteLine($"{attacker}의 공격!");
            Console.WriteLine($"    {target}에게 {damage} 데미지!");
        }



        static void Main(string[] args)
        {
            //함수 호출 시 인자 전달
            GreetPlayer("홍길동");
            Console.WriteLine();

            ShowPlayerInfo("전사", 50);
            Console.WriteLine();

            DrawHealthBar(75, 100, 20);
            DrawHealthBar(30, 100, 20);
            DrawHealthBar(100, 100, 20);
            Console.WriteLine();


            ShowDamage("플레이어", "고블린", 85);
            Console.WriteLine();
            ShowDamage("드래곤", "플레이어", 120);

        }
    }
}
