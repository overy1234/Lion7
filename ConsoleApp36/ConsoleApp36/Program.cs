using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{

    class Character
    {
        //private int Att; //은닉성
        ////Get / Set함수
        //public void SetAtt(int _Att)  //일반함수
        //{
        //    Att = _Att;
        //}
        //public int GetAtt() //일반함수
        //{
        //    return Att;
        //}

        //private int att;
        //public int Att
        //{
        //    get { return att; }

        //    set 
        //    {
        //        att = value;
        //    }

        //}

        public int Att { get; set; } //자동프로퍼티

        //읽기 전용
        public int MaxHP {  get; private set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();

            c.Att = 1;

            Console.WriteLine("공격력: " + c.Att);

          
        }
    }
}
