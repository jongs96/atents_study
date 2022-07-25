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
        {//함수 심화(재귀함수) : 함수 안에서 자기 자신을 호출하는 것.
         //Console.WriteLine(TotalSum(100));
         //100 + (99 + (98 + (... + 조건이 없다면 무한히 더함.
         //연습문제 : 제곱연산을 하는 함수를 재귀함수로 구현하세요.
         //Power(3, 9) = 3 * (3 * (3 * (3 *  ...)))9번
         //Console.WriteLine(Power(2, 8));

            //문자, 문자(배열)
            //char a = '가';// 한글자씩 입력할 경우''
            //a = (char)(a + 2);
            //Console.WriteLine(a);
            Console.WriteLine(AddJosa("보험", "를", "을"));
        }

        static string AddJosa(string name, string moum, string jaum)
        {//단어에 받침이 있는경우(2) 없는경우(1)의 조사를 붙여주는 함수
            if((name[name.Length-1]-16)%28 == 0)//유니코드표의 규칙 상 28마다 받침이 없는 글자 반복됨.
            {//시작지점을 0으로 만들기위해 -16 
                return name + moum;
            }
            return name + jaum;
        }
        //static int Power(int x, int y)// 제곱의 값 구하는 재귀함수.
        //{
        //    if (y == 1)
        //        return x;
        //    return x * Power(x, y - 1); 
        //}
        //static int TotalSum(int n)
        //{// 반복문에서 조건을 잘못준다면 무한반복되는 것처럼 멈추는 조건을 제대로 설정해야함.
        //    if (n == 1)
        //        return 1;
        //    return n + TotalSum(n - 1);// 종료 조건을 제대로 명시해야한다.
        //}
    }
}