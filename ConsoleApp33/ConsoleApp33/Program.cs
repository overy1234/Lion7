using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    
    //클래스 정의
    class Character
    {
        //public 다른곳에서 사용가능하게 한다.
        //private 클래스 나자신 내부에서만 사용하게 한다.
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;
        
        //기본 생성자  초기화용도로 많이사용
        public Character()
        {
            name = "홍길동";
            level = 1;
            hp = 100;
            maxHP = 150;
            mp = 80;
            maxMP = 100;
        }

        //인자있는 생성자
        public Character(string _name , int _level , int _hp,int _maxHP, int _mp, int _maxMP)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _maxHP;
            mp = _mp;
            maxMP = _maxMP;
        }



        //함수를 모아서 사용
        public void ShowStats()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("레벨 : " + level);
            Console.WriteLine("Hp : " + hp);
            Console.WriteLine("MaxHP : " + maxHP);
            Console.WriteLine("MP : " + mp);
            Console.WriteLine("MaxMP : " + maxMP);
        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            //객체 생성
            Character player = new Character(); //생성자가 호출
            player.ShowStats();

          

            Character player2 = new Character("마법사", 2, 110, 250,80,100);
            player2.ShowStats();           

        }
    }
}
