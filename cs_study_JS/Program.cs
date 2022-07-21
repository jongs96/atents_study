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
        static void Main(string[] args)
        {//매개변수 디폴트값==옵셔널 파라미터.
            //call by value(값으로 호출), call by reference(참조로 호출)
            int num1 = 10;
            int num2 = 20;
            Swap(num1, num2);
            Console.WriteLine($"{num1} {num2}");
            //이런경우 num1과 num2의 값은 바뀌지 않는다.
            Swap(ref num1, ref num2);
            Console.WriteLine($"{num1} {num2}");
            //num1과 num2의 값이 변경된다.
            //ref 키워드를 붙이지 않으면 call by value형식 호출이다.
        }

        static void Swap(int a, int b)//a와 b의 값을 바꾸는 함수.>>main에서 실행시 값이 변경x
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Swap(ref int a,ref int b)//a와 b의 값을 바꾸는 함수.>>main함수 값이 바뀜.
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}//call by value : 값을 복사해서 사용
//call by reference : 해당 변수를 직접 사용