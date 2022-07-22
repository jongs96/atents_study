using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//절차지향
//함수지향

namespace cs_study_JS
{
     class Program
    {
        enum STATE
        {// 00000,   00001,     00010,          00100,        01000          10000
            NORMAL, HUNGRY = 1, SLEEPY = 1<<1, ANGRY =1 << 2, WEAK = 1 << 3, POISONED = 1 << 4
        }

        static void Main(string[] args)// main 함수 생성규칙.
        {
            //Mask : 다양한 상태를 한번에 표현하게 해줌
            //비트 연산을 통해서 상태를 추가, 제거, 확인 할 수 있다.
            int Mask = 0;
            //상태추가(|)
            //0000 0001 -> 0001
            Mask |= (int)STATE.HUNGRY;
            //0001 0010 -> 0101
            Mask |= (int)STATE.ANGRY;

            //확인(&) 0101 & 0001 -> 0001
            hasState(Mask, STATE.HUNGRY);

            //제거(^)0101^0001 -> 0100   xor : 값이 다를때만 1
            Mask ^= (int)STATE.HUNGRY;
            hasState(Mask, STATE.HUNGRY);

            int num = ~0;
            Console.WriteLine(num);
        }        

        static void hasState(int mask, STATE s)
        {
            int res = mask & (int)s;
            switch((STATE)res)
            {
                case STATE.ANGRY:
                    Console.WriteLine("화가나요.");
                    break;
                case STATE.HUNGRY:
                    Console.WriteLine("배고파요.");
                    break;
                case STATE.POISONED:
                    Console.WriteLine("중독상태입니다.");
                    break;
                case STATE.SLEEPY:
                    Console.WriteLine("졸려요.");
                    break;
                case STATE.WEAK:
                    Console.WriteLine("아파요.");
                    break;
                default:
                    Console.WriteLine("???");
                    break;
            }
        }
    }
}