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
            //따로 선언하지 않아도 call by reference 로 되는 경우
            //배열의 경우는 애초부터 참조형이다.
            int[] Numlist = { 1, 2, 3, 4, 5 };
            Change(Numlist);
            Console.WriteLine(Numlist[0]);
        }

        static void Change(int[] list)
        {
            list[0] = 100;
        }
    }
}//call by value : 값을 복사해서 사용
//call by reference : 해당 변수를 직접 사용