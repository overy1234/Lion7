using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
//## 6.8 실전 프로젝트: RPG 캐릭터 시스템

//### 💻 종합 예제
    // 캐릭터 클래스
    class RPGCharacter
    {
        // Private 필드
        private string name;
        private string job;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;
        private int attack;
        private int defense;
        private int exp;
        private int gold;

        // Public 프로퍼티
        public string Name { get { return name; } }
        public string Job { get { return job; } }
        public int Level { get { return level; } }
        public int HP { get { return hp; } }
        public int MaxHP { get { return maxHP; } }
        public int MP { get { return mp; } }
        public int MaxMP { get { return maxMP; } }
        public int Attack { get { return attack; } }
        public int Defense { get { return defense; } }
        public int Gold { get { return gold; } }

        // 생성자
        public RPGCharacter(string characterName, string characterJob)
        {
            name = characterName;
            job = characterJob;
            level = 1;
            exp = 0;
            gold = 100;

            // 직업별 초기 스탯
            if (job == "전사")
            {
                maxHP = 150;
                maxMP = 50;
                attack = 60;
                defense = 50;
            }
            else if (job == "마법사")
            {
                maxHP = 100;
                maxMP = 150;
                attack = 80;
                defense = 30;
            }
            else if (job == "궁수")
            {
                maxHP = 120;
                maxMP = 80;
                attack = 70;
                defense = 40;
            }

            hp = maxHP;
            mp = maxMP;

            Console.WriteLine($"✅ {name} ({job}) 캐릭터가 생성되었습니다!");
        }

        // 스탯 표시
        public void ShowStatus()
        {
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine($"║  {name} - {job,-20}        ║");
            Console.WriteLine($"║  레벨: {level,-32}║");
            Console.WriteLine("╠═══════════════════════════════════════════╣");
            Console.WriteLine($"║  HP: {hp}/{maxHP,-30}║");
            Console.WriteLine($"║  MP: {mp}/{maxMP,-30}║");
            Console.WriteLine($"║  공격력: {attack,-31}║");
            Console.WriteLine($"║  방어력: {defense,-31}║");
            Console.WriteLine($"║  경험치: {exp}/100{"",-27}║");
            Console.WriteLine($"║  골드: {gold,-33}║");
            Console.WriteLine($"╚═══════════════════════════════════════════╝");
        }

        // 공격
        public int AttackTarget(RPGCharacter target)
        {
            Random random = new Random();
            bool isCritical = random.Next(1, 101) <= 20;

            int damage = this.attack - target.defense / 2;
            if (damage < 0) damage = 0;

            // 데미지 편차
            int variance = random.Next(-10, 11);
            damage = damage * (100 + variance) / 100;

            if (isCritical)
            {
                damage = (int)(damage * 1.5);
                Console.WriteLine($"⚔️ {this.name}의 크리티컬 공격!");
            }
            else
            {
                Console.WriteLine($"⚔️ {this.name}의 공격!");
            }

            target.TakeDamage(damage);
            return damage;
        }

        // 데미지 받기
        private void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp = 0;

            Console.WriteLine($"   {name}에게 {damage} 데미지!");
            Console.WriteLine($"   남은 HP: {hp}/{maxHP}");

            if (hp == 0)
            {
                Console.WriteLine($"💀 {name}이(가) 쓰러졌습니다!");
            }
        }

        // 회복
        public void Heal(int amount)
        {
            hp += amount;
            if (hp > maxHP) hp = maxHP;

            Console.WriteLine($"💚 {name}의 HP 회복: +{amount}");
            Console.WriteLine($"   현재 HP: {hp}/{maxHP}");
        }

        // 마나 회복
        public void RestoreMP(int amount)
        {
            mp += amount;
            if (mp > maxMP) mp = maxMP;

            Console.WriteLine($"💙 {name}의 MP 회복: +{amount}");
            Console.WriteLine($"   현재 MP: {mp}/{maxMP}");
        }

        // 스킬 사용
        public bool UseSkill(RPGCharacter target, int manaCost)
        {
            if (mp < manaCost)
            {
                Console.WriteLine($"❌ {name}의 마나가 부족합니다!");
                return false;
            }

            mp -= manaCost;

            int skillDamage = attack * 2;

            if (job == "전사")
            {
                Console.WriteLine($"⚡ {name}의 '강타' 발동!");
            }
            else if (job == "마법사")
            {
                Console.WriteLine($"🔥 {name}의 '파이어볼' 발동!");
                skillDamage = (int)(attack * 2.5);
            }
            else if (job == "궁수")
            {
                Console.WriteLine($"🏹 {name}의 '다중 사격' 발동!");
            }

            Console.WriteLine($"   마나 소모: {manaCost}");
            target.TakeDamage(skillDamage);

            return true;
        }

        // 경험치 획득
        public void GainExp(int amount)
        {
            exp += amount;
            Console.WriteLine($"💯 경험치 +{amount} (현재: {exp}/100)");

            while (exp >= 100)
            {
                LevelUp();
                exp -= 100;
            }
        }

        // 레벨업
        private void LevelUp()
        {
            level++;
            maxHP += 20;
            maxMP += 10;
            attack += 5;
            defense += 3;
            hp = maxHP;
            mp = maxMP;

            Console.WriteLine($"⬆️ 레벨 업! {name}의 레벨이 {level}이 되었습니다!");
            Console.WriteLine($"   HP +20, MP +10, 공격력 +5, 방어력 +3");
        }

        // 골드 획득
        public void GainGold(int amount)
        {
            gold += amount;
            Console.WriteLine($"💰 골드 +{amount} (현재: {gold}골드)");
        }

        // 생존 확인
        public bool IsAlive()
        {
            return hp > 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║          RPG 캐릭터 시스템               ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝\n");

            // 캐릭터 생성
            RPGCharacter player = new RPGCharacter("용사", "전사");
            RPGCharacter enemy = new RPGCharacter("어둠의 기사", "전사");

            Console.WriteLine();

            // 초기 상태
            player.ShowStatus();
            Console.WriteLine();
            enemy.ShowStatus();

            // 전투 시작
            Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("              ⚔️ 전투 시작! ⚔️");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

            int turn = 1;

            while (player.IsAlive() && enemy.IsAlive())
            {
                Console.WriteLine($"[ 턴 {turn} ]");
                Console.WriteLine();

                // 플레이어 턴
                if (turn % 3 == 0)
                {
                    player.UseSkill(enemy, 20);
                }
                else
                {
                    player.AttackTarget(enemy);
                }

                Console.WriteLine();

                if (!enemy.IsAlive())
                {
                    break;
                }

                // 적 턴
                enemy.AttackTarget(player);

                Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

                turn++;

                if (turn > 10) break;  // 안전장치
            }

            // 전투 결과
            if (player.IsAlive())
            {
                Console.WriteLine("╔═══════════════════════════════════════════╗");
                Console.WriteLine("║              🎉 승리! 🎉                 ║");
                Console.WriteLine("╚═══════════════════════════════════════════╝\n");

                player.GainExp(80);
                player.GainGold(500);

                Console.WriteLine();
                player.ShowStatus();
            }
            else
            {
                Console.WriteLine("╔═══════════════════════════════════════════╗");
                Console.WriteLine("║             💀 패배... 💀                ║");
                Console.WriteLine("╚═══════════════════════════════════════════╝");
            }
        }
    }
}
