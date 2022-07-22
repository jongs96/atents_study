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
            //숫자를 입력받고 입력 받은 숫자를 비트로 출력하세요.
            //hint
            //Num & 1 = 1이면 마지막 bit가 1이라는 의미 
            //Num & (1 << 1) 1이면 마지막 2번째 비트가 1이라는 의미
            Console.WriteLine("숫자를 입력하세요.");
            int Num = int.Parse(Console.ReadLine());
            //Change(Num);
            //선생님코드
            string res = "";
            int check = 1 << 31;// < 뱡향으로 shift는 빈공간 0,
                                // >방향 첫자리가 1인 상태에서 shift는 빈공간 1로 채워짐
            for (int i = 31; i >= 0; --i)
            {
                check = 1 << i;
                if ((Num&check)==0)
                {
                    //0
                    res += "0";
                }
                else
                {
                    res += "1";
                }
            }
            Console.WriteLine(res);
        }        

        //static void Change(int num)
        //{
        //    int bit = 1<<31;
        //    string number = "";
        //    while(bit!=0)
        //    {
        //        if((num & bit) == bit)
        //        {
        //            number += "1";
        //        }
        //        else
        //        {
        //            number += "0";
        //        }
        //        bit = bit >> 1;
        //    }
        //    Console.WriteLine(number);
        //}
    }
}