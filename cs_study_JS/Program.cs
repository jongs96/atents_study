using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//절차지향
//함수지향
//객체지향 4대 특성
//1. 캡슐화
//접근지정자로 인해 가능한 것
//private-개인적인 것 외부에 숨기는 것 : ex. 스마트폰의 내부 칩들 - 손상되면 안되는 것. 정보 은폐, 기능 고정 
//protected, public : 공개해야하는 것.
//2. 상속
//3. 
//4.

namespace cs_study_JS
{
    class Animal // 동물 이라는 설계도
    {
        //데이타(정보) 은폐 - 변수로 설계 >>멤버 변수(클래스에 속해있는 변수라는 의미)
        string name;//private 이라는 접근지정자가 생략되어있는 것.
                    //기본적으로 접근지정자를 지정해 주지않으면 private생략상태이다.
        //프로퍼티 : 외부에선 변수처럼 사용되고 보이지만 내부에선 함수처럼 사용되는
        //상황에 따라 다르게 사용되는 스마트한 함수
        public string Name
        {
            get => name;
            /*get//호출을 요구하는 경우
            {
                return name;
            }
            */
            set => name = value;
            /*set//어떠한 갑이 대입되면
            {
                name = value;
                //== SetName(value);//value = 내가 집어넣으려고 하는 값.
            }
            */
        }//정해진 포맷 /c#에만 존재.
        int age;
        float height;
        float weight;
        //기능, (행동) - 함수 >>멤버 함수(클래스에 속해있는 함수라는 의미)
        //생성자 - public이어야 한다.
        public Animal(string name)//클래스이름과 동일하게 함수처럼 만들면 생성자라고 함.
        {//인스탄스가 만들어졌을 때 해야할 일이있다면 이곳에서 처리됨.
            this.name = name;//멤버변수에서 this가 기본적으로 생략되어있다.
            this.age = 1;
            height = 0.3f;
            weight = 0.25f;
        }
        //class는 기본생성자를 가지고 만들어진다.


        public void SetName(string name)
        {
            this.name = name; //this = 자신의 인스탄스
                              //여러 인스탄스 중에 자신의 인스탄스 name만 변경되는 것이다.
        }
        public string GetName()//캡슐화로 data가 숨겨져 있기 때문에 이름을 확인하려면 가져와야함.
        {
            return name;
        }
        /**
        public void Cry()//동물마다 우는게 달라서 하나 지정해주기 어려움.(상속을 사용함)
        {
            Console.WriteLine("...");
        }각각 다른 것은 자식에게 지정함.
        */
        void Run()
        {

        }
        void Eat()
        {

        }
        void Sleep()
        {

        }
        //가상함수(virtual) 테이블
        public virtual void Cry()
        {
            Console.WriteLine("...");
        }
    }

    class Dog : Animal //Dog class는 animal class 를 포함함<상속함> 
    {
        public Dog(string name) : base(name) //>>부모 생성자를 호출하는 방법 : 생성자 inicialrise 
        {

        }
        public override void Cry()//override(생략가능함.) : 재정의 (부모에서 가상화 한 것)
        {//재정의 된 것이 없으면 부모의 값이 실행됨.
            Console.WriteLine("멍멍!");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        public override void Cry()//가독성을 위해 override 적어주는것이 좋음.
        {
            Console.WriteLine("야옹 야옹~");
        }
    }
    class Program
    {
        static void Main(string[] args)// main 함수 생성규칙.
        {//객체지향 - class, struct
         //객체 위주로 프로그래밍 하기 위해 사용.
         //class(중요) ex)설계도 - class, 설계도로 만들어진 객체 - 인스탄스 
         //Animal ani = new Animal("any");//실제 인스탄스를 new라는 키워드로 만든 것.
         //clss type으로 선언한 변수는 참조형이다.
         //ani는 Animal이라는 설계도로 만들어진 인스탄스이다.
         //창고(메모리)를 효율적으로 사용하기 위해 stack, heap, data, code 4개의 영역으로 나누어 사용함.
         //지역변수 - stack, 인스탄스 - heap 에 생긴다. 
         //ani는 참조형 변수이고 heap의(인스탄스)가 참조되며 사용하는 것이다.
         //heap의 인스탄스는 블록스코프가 끝나도 사라지지 않는다.
         //필요없을 경우 (참조하는 변수가 하나도 없을 때)에만 자동으로 사라진다.
         //ani.SetName("Lala");//public 이면 변경, 가져오기 가능.
         //접근지정자가 private이면 가져오거나 변경할 수 x
         //Dog ani = new Dog("Baduki");
         ////ani.Name = "Baduki";
         //ani.Cry();
         //Console.WriteLine(ani.Name);
            Animal[] animals = new Animal[2];//만드는 건 부모클래스
            //부모로 묶어서 관리해야지 효율적인 처리, 관리가 가능하다.
            animals[0] = new Dog("Baduki");//지정하는 것은 자식으로 했음
            animals[1] = new Cat("Navi");
            animals[0].Cry();//자식>>부모 형변환 가능(up casting) 자식 class는 부모 참조가능
                             //부모>>자식 참조 불가 부모에는 cry가 없어서 오류가 났었고 cry만들어줘야함.
            animals[1].Cry();//부모로 실행했지만 부모는 가상함수이고 자식의 것을 사용가능

            //Dog dog = (Dog)animals[0];//부모>>자식 casting
            //downcasting 원래 만들어져있던 얘로만 가능함
            //dog.Cry();

            //불가예시 : 다른 자식으로 형변환
            Dog dog = animals[0] as Dog;//as키워드로(검사) 
            if(dog!= null)//변환이 가능 할 때만 
            {
                dog.Cry();
            }

        }
    }
}