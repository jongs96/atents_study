using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//절차지향
//함수지향
//객체지향 4대 특성
namespace cs_study_JS
{
    class Program
    {
       
        static void Main(string[] args)// main 함수 생성규칙.
        {
            //동적배열
            //기존에 만들었던 배열은 정적배열.
            //int[] list = new int[100]; //배열의 크기가 100으로 고정되어있음
            //ex)100명의 학생이 학급에 있었다가 1명이 전학이 와 1개의 자리가 더 필요할 경우.
            //using System.Collections.Generic;입력 해당 namespace에 동적배열 관련 내용들이있다.
            List<int> list = new List<int>() {1, 2, 3, 4, 5};//동적배열 생성/값할당
            //배열의 크기 [5] 1,2,3,4,5가 들어있는
            list.Add(10);//배열의 크기를 늘려주는 함수 10원소 추가
            list.Add(20);
            list.Add(20);
            list.Add(30);
            DrawList<int>(list);

            list.Remove(10);//해당되는 값 중 첫번째 값을 지운다
            DrawList<int>(list);

            list.RemoveAt(3);//해당위치 인덱스 값을 지운다.
            DrawList<int>(list);
            //
            //list.RemoveAll(IsEqual);//해당 숫자 모두를 지운다. 값을 찾는 함수를 요구함
            //값대신 함수가 parameter로 전달 하는 delegate
            /*
            for(int i = 0; i < list.Count;)//배열은 Length, list는 Count
            {
                if(IsEqual(list[i]))
                {
                    list.RemoveAt(i);
                    continue;
                }
                ++i;//자동증가 안하는 이유. 지웠을 때, 지나치는 index가 생김.
            }Remove all 같은내용
            */
            //익명함수 - 람다식(익명함수를 표현하는 문법)
            //list.RemoveAll((int n) => { return n == 20; });
            int num = 20;
            list.RemoveAll(n => n == num);//윗줄 이렇게 생략가능함. 이런식을 람다식이라함.
            /*
            list.RemoveAll(
                (int n)=>
                {
                    return n == 20;
                }); 다른곳에서 호출할 수 없는 이름, 반환값이 없는 함수를 익명함수라고 함.
             */
            list.Remove(30);
            DrawList<int>(list);

            if(list.Contains(30))//해당 list에 어떤값이 있는지 확인해야할 경우 ,true/false 값 반환
            {
                Console.WriteLine("30이 존재합니다.");
            }
            else
            {
                Console.WriteLine("30이 존재하지 않습니다.");
            }
        }
        static bool IsEqual(int n)
        {
            return n == 20;
        }
        static bool IsEqual2(int n)
        {
            return n == 30;
        }//상황에 따라 필요한 함수를 계속 만들어야하고, 순간적 필요에 따라 못만드는 것이 불편함
        //익명함수(중 람다식)를 이용한다.
        static void DrawList<T>(List<T>list)
        {
            foreach(T t in list)
            {
                Console.Write($"[{t}]");
            }
            Console.WriteLine();
        }
    }
}
//기술면접내용 이론
//저장공간 : stack, heap, data, code
//stack : 지역변수 만들어지고 사라지고 , 구조체도 여기.
//heap : class로 만들어진 인스탄스 만들어지고사라지고
//data : static으로 만들어진 함수 ,리터럴 상수
//code : 함수가 저장되는 영역
//code에 저장된 함수는 모두가 함께 사용하나 this키워드로 변수값 변경이 됨.

//GC(garbage collector)메모리 관리를 도와주는 c#에있는 것.
//참조되지 않는 인스탄스 등을 삭제하며 관리해줌.
//heap공간이 줄어들다가 일정이하로 내려가면 발동해서 삭제함.
//GC발동하는 순간에 frame dowm현상이 발생할 수 있다.
//그래서 garbage를 최대한 적게 생기도록 신경을 써야 좋은 게임을 만들 수 있다.

//boxing unboxing

//delegate 잘 다룰 줄 알아야 한다.