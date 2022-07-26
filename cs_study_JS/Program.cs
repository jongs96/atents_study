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
        static int test = 0;
        static void Main(string[] args)// main 함수 생성규칙.
        {
            //Student a = new Student();//a라는 인스탄스 생성. new키워드로
            //Student설계도로 만든 a > a라는 Student 형 type 의 참조형 변수(Student를 참조하는)
            //a.Name = "Lee"; //프로퍼티 Name으로 이름 설정
            //ChangeName(a, "kim");//call by reference 형식 class는 무조건 참조형 이기에 kim으로 변경된다.
            //Console.WriteLine($"Student Name is {a.Name}");

            /*ex
            string a = "";
            ChangeName(a, "Kim");
            Console.WriteLine($"Student Name is {a.Name}");예외사항으로 string 은 변경이 안된다.
            */

            //Student.Name = ""; //안됨. 설계도의 이름을 바꾸는것이 안되어서
            //Student.TotalNum = 1;//heap공간에 만들어진 모든 인스탄스는 data영역에 만들어진 TotalNumdmf rhddbgka
            {
                Student a = new Student("Kim");//구조체는 a라는 얘는 kim이름을 가진 값형태의 변수가된다.
                Student b = new Student("Lee");
                Student c = new Student("Min");

                ChangeName(a, "Park");
                Console.WriteLine($"Student Name is  {a.Name}");//{}블록스코프 밖으로 나가면 참조자가 사라져서 쓰레기가 되는것.
            }//class였다면 {}안의 값 garbage 값이 됨
            //구조체로 만들면 garbage가 생기지 않는다.>> 지역이 종료되면 사라지기때문에.
            
            /*
            for(int i = 0; i < 10000; i++)
            {
                Student temp = new Student("");
            }
            class라면 만개의 garbage가 만들어지는 것임. stuct라면 0개
            */

            Console.WriteLine($"현재 학생은 총 {Student.GetTotalCount()}입니다.");
        }//구조체는 값형 class는 참조형 class는 인스탄스를 생성해야 사용됨
         //몬스터, 캐릭터 : class, 아이템 : struct
        /*
        static void ChangeName(string str, string name)
        {
            str = name;
        }
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