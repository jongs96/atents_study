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
    public delegate int Func(int a, int b);//delegate 반환 값 int , a,b 인자를 전달받는 함수type이면
                                           //저장이 가능하다.
    class Program
    {
       
        static void Main(string[] args)// main 함수 생성규칙.
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for(int i =0; i<10; ++i)
            {
                list.Add(rnd.Next(1, 101));
            }
            DrawList<int>(list);
            list.Sort();//오름차순 정렬
            DrawList<int>(list);
            //list.Sort(Compare);//내림차순 정렬
            Func func = (a, b) => a > b ? -1 : a == b ? 0 : 1;//이런식으로 함수를 저장해서 변수처럼 쓴다.
            //사용 예시delegate
            func(1, 2);
            func?.Invoke(1, 2);//func 값이 null이 아니면 저장된함수 사용.

            list.Sort((a, b) => a > b ? -1 : a == b ? 0 : 1);//람다식을 이용한 익명함수
            //list.Sort((a, b) => a > b ? 1 : a == b ? 0 : -1);//오름차순
            DrawList<int>(list);
        }

        static int Compare(int a, int b)
        {
            if (a > b) return -1;//Sort함수에 -1, 0 return 되면 값을 바꾸지않고
            else if (a == b) return 0;
            else return 1;         //바꿔야하는 경우 return 값이 1이 되면된다.
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

//delegate : 함수를 저장할 수 있는 변수
//잘 다룰 줄 알아야 한다.