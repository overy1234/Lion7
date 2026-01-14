using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Monster
    {
        // 필드
        public string name;
        public int level;
        public int hp;
        public int attack;
        public int defense;
        public int expReward;


        // 기본 생성자
        public Monster()
        {
            name = "슬라임";
            level = 1;
            hp = 50;
            attack = 10;
            defense = 5;
            expReward = 10;
        }

        // 매개변수가 있는 생성자
        public Monster(string monsterName, int monsterLevel)
        {
            name = monsterName;
            level = monsterLevel;
            hp = 50 * level;
            attack = 10 * level;
            defense = 5 * level;
            expReward = 10 * level;
        }

        // 정보 출력
        public void ShowStats()
        {
            Console.WriteLine($"👾 {name} (Lv.{level})");
            Console.WriteLine($"   HP: {hp}");
            Console.WriteLine($"   공격력: {attack}");
            Console.WriteLine($"   방어력: {defense}");
            Console.WriteLine($"   경험치: {expReward}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //기본생성자 사용해서 객체 생성
            Monster slime = new Monster();
            //스탯출력
            slime.ShowStats();

            // 매개변수가 있는 생성자 사용
            //고블린 5
            Monster goblin = new Monster("고블린", 5);
            //스탯출력
            goblin.ShowStats();

            Console.WriteLine("=== 필드 몬스터 ===\n");
            Monster[] monsters = new Monster[3];
            monsters[0] = new Monster("늑대", 3);
            monsters[1] = new Monster("오크", 7);
            monsters[2] = new Monster("트롤", 10);

            for(int i =0; i<monsters.Length; i++)
            {
                monsters[i].ShowStats();
                Console.WriteLine();
            }



        }
    }
}
