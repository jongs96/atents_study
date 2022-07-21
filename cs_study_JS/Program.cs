using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_study_JS
{
    class Program
    {
        static void Main(string[] args)//Main 함수
        {
            //지역변수
            //지역변수는 {}블록스코프 내에서만 존재한다.

            //배열
            string Student1 = "Kim";
            string Student2 = "Lee";//이러한 연속된 변수를 저장하기 위한 공간.

            string[] Students = new string[5];//선언 형식: 타입[] 배열이름 = new 타입[갯수];
            Students[0] = "Kim";//첫번째 배열에 Kim대입
            Students[1] = "Lee";//두번째 배열에 Lee대입

            string[] Students2 = { "Kim", "Lee", "Pak", "Choi", "kang" };
            //선언과 동시에 배열의 값 설정 설정 개수에 맞게 배열생성된다.

            int[] Numlist = new int[10];
            for(int i =0; i<Numlist.Length; ++i) //Numlist.Length : 배열의 갯수
            {
                Numlist[i] = 10;
            }
            //배열 반복문을 통해 값 입력

            //배열에서 사용하는 반복문 : foreach(범위형 반복문)
            //배열의 첫번째 index부터 마지막번호까지 자동으로 반복하는 반복문이다.
            //시스템 내부적으로 처리속도가 빨라서 사용하는것이 더 좋다.
            foreach(int Num in Numlist)
            {
                Console.WriteLine(Num);
            }

        }
    }
}