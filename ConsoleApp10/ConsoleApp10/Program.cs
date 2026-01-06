using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열로 받기
            //Console.WriteLine("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); //사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요,{userName}님!"); //입력값 출력

            //문자열을 정수로 변환
            //Console.WriteLine("나이를 입력하세요: ");
            //string input = Console.ReadLine(); //사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!"); 

            //이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환

            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2); //10진수->2진수변환


            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");


            //=== 캐릭터 생성 ===
            //캐릭터 이름을 입력하세요: 홍길동
            //환영합니다, 홍길동님!
            //시작 레벨을 입력하세요: 5
            //홍길동님의 시작 레벨은 5입니다.

            //Console.WriteLine("=== 캐릭터 생성 ===");

            //// 문자열 입력
            //Console.Write("캐릭터 이름을 입력하세요: \n");
            //string playerName = Console.ReadLine();

            //Console.WriteLine($"\n환영합니다, {playerName}님!");

            //// 숫자 입력 (문자열 → 숫자 변환 필요)
            //Console.Write("시작 레벨을 입력하세요: ");
            //string levelInput = Console.ReadLine();
            //int playerLevel = int.Parse(levelInput);

            //Console.WriteLine($"{playerName}님의 시작 레벨은 {playerLevel}입니다.");

            //var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25; //정수로 추론
            //var isStudent = true;//논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");

            //default 키워드를 사용한 기본값 설정
            //int defaultInt = default;  //0
            //string defaultString = default; //null
            //bool defaultBool = default; //false

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");


            //1. 암시적 변환 (작은 타입 -> 큰 타입)
            int smallNumber = 100;
            long bigNumber = smallNumber; //int ->long(자동 변환)
            double doubleNumer = smallNumber; //int -> double(자동 변환)


            Console.WriteLine("=== 암시적 변환 ===");
            Console.WriteLine($"int: {smallNumber.GetType()}");
            Console.WriteLine($"long: {bigNumber.GetType()}");
            Console.WriteLine($"double: {doubleNumer.GetType()}");

            //2.명시적 변환 (큰타입 ->작은타입)
            double pi = 3.14159;
            int intPi = (int)pi;  //소수점을 버림!(명시적 변환 필요)

            Console.WriteLine("\n=== 명시적 변환 ===");
            Console.WriteLine($"double : {pi}");
            Console.WriteLine($"int로 변환 : {intPi}"); //3.14...     3

            //int,flaot ,double, char,long  정파
            //string 사파 커스터마이징 
            //스타벅스 tall  벤티 그란데 
            //개인 텀블러 
            //클래스 신공 구절다외우기힘듬 

            //3. 문자열을 숫자로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); //문자열 -> 정수

            string priceText = "19.99";
            double price = double.Parse(priceText);  //문자열 -> 실수

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"점수(문자열) : {scoreText} -> 숫자: {score}");
            Console.WriteLine($"가격(문자열) : {priceText} -> 숫자: {price}");

            //4.숫자를 문자열로 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString();

            Console.WriteLine("==== 숫자를 문자열로");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열 : {levelText}");



          



        }
    }
}
