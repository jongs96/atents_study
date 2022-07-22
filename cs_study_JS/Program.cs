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
        enum RockPaperScissors//*새로운 개념 >>> enum : 열거형 type
        {//RockPaperScissors라는 타입을 만든 것. 
            Gawi, Bawi, Bo//해당 값만 가질 수 있고 정수형 타입이다.
        }//실제 값 Gawi = 0, Bawi = 1, Bo = 2 >> 값을 넣지 않는 경우 Default
        //값을 지정 가능 ex) Gawi=100, Bawi, Bo >> Gawi=100, Bawi =101, Bo =102
        //각각 지정도 가능하다
        static void Main(string[] args)// main 함수 생성규칙.
        {
            //
            int sum;
            Sum(4, 5, out sum);
            Console.WriteLine(sum);
        }

        static void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }
    }
}//programing 할때 최대한 실수 없는 코드를 짜라. bug를 줄일 수 있다.

//예외사항 정해진 규칙대로 당연히 돌아갈 것이라고 생각하면 안됨.
