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
        {//6개의 1~45까지의 로또번호를 뽑고 list를 사용해 오름차순으로 출력
         //+중복검사
            Random rnd = new Random();

            List<int> balls = new List<int>();//공간복잡도 : 기본적으로 45개의 공을 뽑음
            for(int i = 1; i<46; ++i)
            {
                balls.Add(i);
            }

            List<int> LottoNum = new List<int>();
            for(int i = 0; i< 6; ++i)
            {
                int num = rnd.Next(0, balls.Count);
                LottoNum.Add(balls[num]);
                balls.RemoveAt(num);//>> On번 보통의 중복검사 On^2번
            }//1~45의 공중에 하나를 선택해 로또넘버에 넣고 balls에서 해당 공을 제거.
            //6번만 뽑으면 되며 중복검사가 굳이 필요가 없음. > 시간복잡도(=big O)가 적음
            //중요도 시간복잡도 > 공간복잡도
            LottoNum.Sort();
            DrawList<int>(LottoNum);
            LottoNum.Clear();//모든 list 제거
            DrawList<int>(LottoNum);
            LottoNum.InsertRange(0, balls);//범위로 추가
            DrawList<int>(LottoNum);
        }
        static void DrawList<T>(List<T> list)
        {
            foreach (T t in list)
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