using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    using System;

    class ItemEnhancementSystem
    {
        // 강화 확률 계산
        static int GetEnhanceSuccessRate(int level)
        {
            if (level <= 3) return 100;      // +0 ~ +3: 100%
            else if (level <= 6) return 80;   // +4 ~ +6: 80%
            else if (level <= 9) return 60;   // +7 ~ +9: 60%
            else if (level <= 12) return 40;  // +10 ~ +12: 40%
            else if (level <= 15) return 20;  // +13 ~ +15: 20%
            else return 10;                   // +16 이상: 10%
        }

        // 강화 비용 계산
        static int GetEnhanceCost(int level)
        {
            return level * 100 + 500;  // 레벨이 높을수록 비용 증가
        }

        // 실패 시 레벨 감소 계산
        static int GetLevelPenalty(int level)
        {
            if (level <= 6) return 0;     // +6 이하: 감소 없음
            else if (level <= 12) return 1; // +7 ~ +12: 1레벨 감소
            else return 2;                  // +13 이상: 2레벨 감소
        }

        // 강화 시도
        static void TryEnhance(ref int itemLevel, ref int gold, out bool success, out string message)
        {
            int cost = GetEnhanceCost(itemLevel);

            // 골드 부족 체크
            if (gold < cost)
            {
                success = false;
                message = "골드가 부족합니다!";
                return;
            }

            // 최대 레벨 체크
            if (itemLevel >= 20)
            {
                success = false;
                message = "최대 강화 레벨입니다!";
                return;
            }

            // 골드 차감
            gold -= cost;

            // 강화 시도
            int successRate = GetEnhanceSuccessRate(itemLevel);
            Random random = new Random();
            int roll = random.Next(1, 101);  // 1~100

            if (roll <= successRate)
            {
                // 성공!
                itemLevel++;
                success = true;
                message = $"강화 성공! +{itemLevel}";
            }
            else
            {
                // 실패...
                success = false;
                int penalty = GetLevelPenalty(itemLevel);

                if (penalty > 0)
                {
                    itemLevel -= penalty;
                    if (itemLevel < 0) itemLevel = 0;
                    message = $"강화 실패... (레벨 -{penalty})";
                }
                else
                {
                    message = "강화 실패... (레벨 유지)";
                }
            }
        }

        // 아이템 정보 출력
        static void ShowItemInfo(int level, int gold)
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"⚔️ 전설의 검 +{level}");
            Console.WriteLine($"💰 보유 골드: {gold}");

            int cost = GetEnhanceCost(level);
            int rate = GetEnhanceSuccessRate(level);
            int penalty = GetLevelPenalty(level);

            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"강화 비용: {cost} 골드");
            Console.WriteLine($"성공 확률: {rate}%");

            if (penalty > 0)
                Console.WriteLine($"실패 시: -{penalty} 레벨");
            else
                Console.WriteLine("실패 시: 레벨 유지");

            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        // 강화 진행 바 출력
        static void ShowProgressBar(int level)
        {
            Console.Write("강화 단계: [");

            for (int i = 0; i < 20; i++)
            {
                if (i < level)
                    Console.Write("█");
                else if (i == level)
                    Console.Write("▶");
                else
                    Console.Write("░");
            }

            Console.WriteLine($"] {level}/20");
        }

        // 자동 강화 (목표 레벨까지)
        static void AutoEnhance(ref int itemLevel, ref int gold, int targetLevel)
        {
            Console.WriteLine($"\n🎯 목표 레벨: +{targetLevel}");
            Console.WriteLine("자동 강화 시작!\n");

            int attempts = 0;
            int successCount = 0;
            int failCount = 0;
            int totalSpent = 0;
            int startGold = gold;

            while (itemLevel < targetLevel && gold >= GetEnhanceCost(itemLevel))
            {
                attempts++;
                int beforeLevel = itemLevel;
                int cost = GetEnhanceCost(itemLevel);

                bool success;
                string message;
                TryEnhance(ref itemLevel, ref gold, out success, out message);

                totalSpent += cost;

                if (success)
                {
                    successCount++;
                    Console.WriteLine($"#{attempts} ✅ {message}");
                }
                else
                {
                    failCount++;
                    Console.WriteLine($"#{attempts} ❌ {message}");
                }

                System.Threading.Thread.Sleep(300);  // 0.3초 대기
            }

            Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine("🏁 자동 강화 완료!");
            Console.WriteLine($"총 시도: {attempts}회");
            Console.WriteLine($"성공: {successCount}회");
            Console.WriteLine($"실패: {failCount}회");
            Console.WriteLine($"사용 골드: {totalSpent}");
            Console.WriteLine($"남은 골드: {gold}");
            Console.WriteLine($"최종 강화 레벨: +{itemLevel}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int itemLevel = 0;
            int gold = 50000;

            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║    ⚔️ 아이템 강화 시스템 ⚔️      ║");
            Console.WriteLine("╚═══════════════════════════════════╝\n");

            while (true)
            {
                ShowItemInfo(itemLevel, gold);
                ShowProgressBar(itemLevel);

                Console.WriteLine("\n[메뉴]");
                Console.WriteLine("1. 강화 시도");
                Console.WriteLine("2. 자동 강화");
                Console.WriteLine("3. 골드 충전 (치트)");
                Console.WriteLine("4. 종료");
                Console.Write("선택: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    // 수동 강화
                    bool success;
                    string message;

                    int beforeLevel = itemLevel;
                    TryEnhance(ref itemLevel, ref gold, out success, out message);

                    if (success)
                    {
                        Console.WriteLine($"✅ {message}");
                        Console.WriteLine("🎉 강화에 성공했습니다!");
                    }
                    else
                    {
                        if (message.Contains("부족") || message.Contains("최대"))
                        {
                            Console.WriteLine($"❌ {message}");
                        }
                        else
                        {
                            Console.WriteLine($"❌ {message}");
                            Console.WriteLine("💔 강화에 실패했습니다...");
                        }
                    }
                }
                else if (choice == "2")
                {
                    // 자동 강화
                    Console.Write("목표 레벨 입력 (현재 +{0}): ", itemLevel);
                    if (int.TryParse(Console.ReadLine(), out int target))
                    {
                        if (target > itemLevel && target <= 20)
                        {
                            AutoEnhance(ref itemLevel, ref gold, target);
                        }
                        else
                        {
                            Console.WriteLine("❌ 잘못된 목표 레벨입니다!");
                        }
                    }
                }
                else if (choice == "3")
                {
                    // 치트
                    gold += 10000;
                    Console.WriteLine("💰 골드 +10,000 (치트 사용)");
                }
                else if (choice == "4")
                {
                    break;
                }

                Console.WriteLine("\n[Enter를 눌러 계속...]");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("\n게임을 종료합니다.");
            Console.WriteLine($"최종 강화 레벨: +{itemLevel}");
            Console.WriteLine($"남은 골드: {gold}");
        }
    }
}
