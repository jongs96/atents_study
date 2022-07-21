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
        {
            //함수 >> 유지보수 비용을 줄여줌, 중복코드 방지-재활용 가능.
            //함수 오버로딩 : 파라미터의 개수, 타입이다르면 함수명이 같아도 실행이된다.

            int num = Sum(10, 10, 10);
            int DefaultNum = Sum();
            Console.WriteLine(Sum("Hi", "Hello"));
            Console.WriteLine(DefaultNum);
        }

        static int Sum(int a = 0, int b = 0)//매개변수 디폴트값. b에 값을 넣지않아도 실행이됨.
        {//디폴트는 뒤쪽에서부터 채워 넣을 수 있다.
            return a + b;
        }
        static string Sum(string a, string b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}