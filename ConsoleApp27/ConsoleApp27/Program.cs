using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {

        // 기본 매개변수 사용
        static void CastFireball(string target, int damage = 100, int manaCost = 30)
        {
            Console.WriteLine($"🔥 파이어볼 시전!");
            Console.WriteLine($"   대상: {target}");
            Console.WriteLine($"   데미지: {damage}");
            Console.WriteLine($"   마나 소모: {manaCost}");
        }

        // 회복 스킬
        static void UsePotion(string potionName = "회복 포션", int healAmount = 50)
        {
            Console.WriteLine($"💊 {potionName} 사용!");
            Console.WriteLine($"   회복량: {healAmount} HP");
        }

        // 소환 스킬
        static void SummonMonster(string monsterType = "슬라임", int level = 1, int count = 1)
        {
            Console.WriteLine($"✨ {monsterType} 소환!");
            Console.WriteLine($"   레벨: {level}");
            Console.WriteLine($"   수량: {count}마리");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== 스킬 시전 ===\n");

            // 모든 매개변수 지정
            CastFireball("고블린", 150, 40);
            Console.WriteLine();

            // 일부만 지정 (나머지는 기본값)
            CastFireball("오크", 200);
            Console.WriteLine();

            // 필수 매개변수만 지정
            CastFireball("드래곤");
            Console.WriteLine();

            Console.WriteLine("=== 아이템 사용 ===\n");

            UsePotion();  // 모두 기본값
            Console.WriteLine();

            UsePotion("고급 회복 포션", 100);
            Console.WriteLine();

            Console.WriteLine("=== 소환 마법 ===\n");

            SummonMonster();  // 기본값: 슬라임, 레벨1, 1마리
            Console.WriteLine();

            SummonMonster("고블린", 5);
            Console.WriteLine();

            SummonMonster("드래곤", 50, 3);
        }
    }
}
