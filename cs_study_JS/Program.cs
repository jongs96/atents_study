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

            //숫자두개를 입력 받고 둘 중 큰 숫자를 알려준다./반환한다.
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            MaxNum(Num1, Num2);

            int num = Sum(10, 20); //반환된 10+20의 값을 num에 저장.
            Console.WriteLine(num);

        }
        static int Sum(int a, int b)//반환형 함수. static 반환타입 함수이름(매개변수)
        {
            return a + b;
        }
        static void MaxNum(int a, int b)//(parameter=매개변수)
        {
            if(a>b)
            {
                /*Console.WriteLine(a +"가 " + b + "보다 큽니다.");*///a문자 변환출력 = a.ToString() >>.ToString()이 생략되어있는것임.
                //Console.WriteLine("{0}가 {1}보다 큽니다.", a, b);//{0}에는 a {1}에는 b가 출력됨.
                Console.WriteLine($"{a}가 {b}보다 큽니다.");// $표시를 붙여야 한다.
            }
            else if(a==b)
            {
                Console.WriteLine($"{a}와 {b}가 같스니다.");
            }
            else
            {
                Console.WriteLine($"{b}가 {a}보다 큽니다.");
            }
        }
    }
}