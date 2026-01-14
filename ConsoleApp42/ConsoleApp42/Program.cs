using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    //클래스끼리 통신
    class Player
    {
        private int hp;
        private int att;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public int GetHp() 
        { 
            return hp; 
        }

        public void SetAtt(int att)
        {
            this.att = att;
        }

        public int GetAtt()
        {
            return att;
        }





        public void Render()
        {
            Console.WriteLine("플레이어");
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("공격력 : " + att);
        }

    }
    class Monster
    {
        private int hp;
        private int att;


        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        public int GetHp()
        {
            return hp;
        }

        public void SetAtt(int att)
        {
            this.att = att;
        }

        public int GetAtt()
        {
            return att;
        }



        public void Render()
        {
            Console.WriteLine("몬스터");
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("공격력 : " + att);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //플레이어객체
            Player player = new Player();
            player.SetAtt(10);
            player.SetHp(100);
            player.Render();

            //몬스터객체
            Monster monster = new Monster();
            monster.SetAtt(5);
            monster.SetHp(100);
            monster.Render();

            //플레이어가 몬스터 때리기   
            monster.SetHp(monster.GetHp() - player.GetAtt());
            //몬스터가 플레이어 때리기
            player.SetHp(player.GetHp() - monster.GetAtt());

        }
    }
}
