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
    struct Student //c#에서는 class와 구조체가 같게 인식됨.
    {//구조체는 사용법도 똑같지만 참조형이 아닌 '값'형이다.
        static int TotalNum = 0;// static 변수(정적변수) 데이타 영역에 생김
        //data영역에 생기는 정적변수는 프로그램이 시작될때 생성, 끝날때 사라짐.
        //public int TotalNum = 0;으로 생성을 해버리면 a,b,c학생이 각자 다른 TotalNum을 가지게되버림.
        string name;//필드
        public string Name//외부에서 사용해야해서 프로퍼티를 만듦
        {//Name을 가지고 출력 입력을 함.
            get => name;
            set => name = value;
        }
        public Student(string name)
        {
            this.name = name;
            TotalNum++;  //멤버변수라 class내에서 사용이 가능하다.
        }
        public void Out()
        {
            TotalNum--;
        }

        //public static int GetTotalCount() => TotalNum;//GetTotalCount함수를 호출하면 TotalNum return
        //함수에 static이 붙으면 인스탄스와는 상관이 없어짐.
        public static int GetTotalCount()
        {
            //Name = "??"; //static함수는 인스탄스와 연관성이 없어져서 인스탄스 안에만 존재하는 값은 사용할 수 x
            return TotalNum;
        }
    }

    //***class(인스탄스), 배열의 이름(배열상자의 첫번째) : 태생이 참조형***
    class Program
    {
        //컬렉션 -Generic- c++의 STL
        //Boxing Unboxing
        static void Main(string[] args)// main 함수 생성규칙.
        {
            //IsEqual<string>("a", "a");//사용을 할 때, 타입을 정해줌
            //object - 모든 변수, 클래스의 부모타입.
            //IsEqual(1, "d");//object로하면 모든 타입 다사용가능 
            //int a = 10;
            //object b = a;//object 는 참조형. heap영역에 (int, 10)의 값이 생김 => boxing
            //int c = (int)b;//=>unboxing c box안에 type 확인 후 값을 넣음.
            //b = 20;//b에 20이 들어간 것이 아닌 참조가 바뀐 것.
            //Boxing , unboxing이 일어나면 시간이 오래걸려 속도가 느려질 수 있다.
            //일어나면 좋지않다.
            object temp = 1;
            temp = "kim";
        }
        /*
        static void ChangeName(string str, string name)
        {
            str = name;
        }
        */
        static bool IsEqual(object a, object b)
        {
            return a.Equals(b);
        }//같은 형태
        //static bool IsEqual<T1, T2>(T1 a, T2 b)
        ////<T>임의의 T라는 의미. template약자라 보통T라고 적음. 2~3개도 지정가능
        //{
        //    return a.Equals(b);
        //} 이러한 generic type으로 하는것이 boxing unboxing 이 일어나지 않는다.
        /*
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static float Sum(float a, float b)
        {
            return a + b;
        }
        //같은 함수, 같은역할인데 다른 데이터타입이라 2개를 만드는것이 비효율적이다.
        */
        static void ChangeName(Student s, string name)//이름 변경하는 함수
        {
            s.Name = name; //s라는 상자에 a가 참조하는 애를 참조하게 했다.
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