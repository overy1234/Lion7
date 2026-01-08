using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;
            //Console.WriteLine(max); 

            //삼항연산자
            //(조건) ?  t : f ;

            //기본 사용법
            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수: {score}");
            //Console.WriteLine($"결과: {result}");

            //예제 2: 레벨에 따른 등급
            //레벨 45
            // 50보다크면 고급  50~ 30 사이이면 중급 그렇지 않으면 초급

            //플레이어등급
            //레벨 :
            //등급 : 

            //int level = 45;
            //string grade = (level >= 50) ? "고급" :
            //               (level >= 30) ? "중급" : "초급";

            //Console.WriteLine("===플레이어 등급 ===");
            //Console.WriteLine($"레벨: {level}");
            //Console.WriteLine($"등급: {grade}");

            //헬쓰 =30;
            //맥스헬쓰 = 100;
            //헬스상태 70  안전   70~30 주의  그보다 낮으면 위험

            //int health = 30;
            //int maxHealth = 100;
            //string healthStatus = (health >= maxHealth * 0.7) ? "안전" :
            //                       (health >= maxHealth * 0.3) ? "주의" : "위험";

            //Console.WriteLine("===체력 상태===");
            //Console.WriteLine($"현재 체력: {health}/{maxHealth}");
            //Console.WriteLine($"상태 : {healthStatus}");

            ////연산자 우선순위
            //int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
            //Console.WriteLine(result); //20

            //int adjustedResult = (10 + 2) * 5; //괄호로 우선순위 변경
            //Console.WriteLine(adjustedResult); //출력 60

            // 예제 2: 데미지 계산
            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0



        }
    }
}
