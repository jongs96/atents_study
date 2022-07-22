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
        static void Main(string[] args)// main 함수 생성규칙.
        {
            //비트연산 &(AND), |(OR), ^(XOR), Shift(<<,>>)
            //int num = 1;//총 32개의 전구 4byte * 8, num = 0000...1
            int num1 = 3;  //0011
            int num2 = 10; //1010
                           //&연산 0010
                           //|연산 1011
                           //^연산 1001
                           //shift연산 x<<y x를 왼쪽으로 y번 shift(빈공간은 0으로 채워진다)

            int res = 11 >> 2;
            Console.WriteLine(res);
        }        
    }
}