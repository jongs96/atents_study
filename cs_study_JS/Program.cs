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
        enum RockPaperScissors//*새로운 개념 >>> enum : 열거형 type
        {//RockPaperScissors라는 타입을 만든 것. 
            Gawi, Bawi, Bo//해당 값만 가질 수 있고 정수형 타입이다.
        }//실제 값 Gawi = 0, Bawi = 1, Bo = 2 >> 값을 넣지 않는 경우 Default
        //값을 지정 가능 ex) Gawi=100, Bawi, Bo >> Gawi=100, Bawi =101, Bo =102
        //각각 지정도 가능하다
        static void Main(string[] args)// main 함수 생성규칙.
        {
            //가위 바위 보 게임
            //시작할 대 1000원을 가지고 시작한다.
            //컴퓨터가 랜덤하게 가위 바위 보 중 하나를 정한다.
            //플레이어가 가위 바위 보를 낸다.
            //(1-> 가위, 2-> 바위, 3->보)로 처리함.
            //승리하면 100원을 받고, 지면 100원을 잃는다.
            //모든 돈을 잃으면 게임오버, 2000원이 되면 승리

            //심화 게임. 플레이어가 돈을 배팅한다 최소금액 100원
            //플레이어가 배팅한 돈만큼 증/감.

            //강사님 코드
            int Money = 1000;
            int Bet;
            Random rnd = new Random();//컴퓨터가 랜덤하게 가위 바위 보 중 하나를 정한다.

            while(Money > 0 && Money < 2000)
            {
                RockPaperScissors Computer = (RockPaperScissors)rnd.Next(0, 3);//Random 값 형변환
                                                                               //게임을 만들 때 UI/UX를 고려해라. UX: 유저의 경험.
                Console.WriteLine($"배팅할 금액과 가위,바위,보 중 하나를 입력하세요!\n[배팅 가능금액:100원 ~ {Money}원][1.가위 2.바위 3.보]");
                Bet = int.Parse(Console.ReadLine());
                RockPaperScissors Player = (RockPaperScissors)(int.Parse(Console.ReadLine()) - 1);

                int result = IsWin(Computer, Player);
                Money += result * Bet;
                switch(result)
                {
                    case -1:
                        Console.WriteLine($"당신이 졌어요. 컴퓨터:{Print(Computer)} 당신:{Print(Player)} Money:{Money}원\n");
                        break;
                    case 0:
                        Console.WriteLine($"비겼네요. 컴퓨터:{Print(Computer)} 당신:{Print(Player)} Money:{Money}원\n");
                        break;
                    case 1:
                        Console.WriteLine($"당신이 이겼어요. 컴퓨터:{Print(Computer)} 당신:{Print(Player)} Money:{Money}원\n");
                        break;
                }
            }

            if (Money <= 0)
            {
                Console.WriteLine("당신은 패배 하였습니다.");
            }
            else
            {
                Console.WriteLine("당신은 승리 하였습니다.");
            }
        }

        static string Print(RockPaperScissors rps)
        {
            switch(rps)
            {
                case RockPaperScissors.Bawi:
                    return "바위";
                case RockPaperScissors.Bo:
                    return "보";
                case RockPaperScissors.Gawi:
                    return "가위";
            }
            return "";
        }

        //강사님 함수
        static int IsWin(RockPaperScissors comp, RockPaperScissors player)
        {
            switch (comp)
            {
                case RockPaperScissors.Bawi:
                    switch (player)
                    {
                        case RockPaperScissors.Bawi:
                            return 0;
                        case RockPaperScissors.Bo:
                            return 1;
                        case RockPaperScissors.Gawi:
                            return -1;
                    }
                    break;

                case RockPaperScissors.Bo:
                    switch (player)
                    {
                        case RockPaperScissors.Bawi:
                            return -1;
                        case RockPaperScissors.Bo:
                            return 0;
                        case RockPaperScissors.Gawi:
                            return 1;
                    }
                    break;

                case RockPaperScissors.Gawi:
                    switch (player)
                    {
                        case RockPaperScissors.Bawi:
                            return 1;
                        case RockPaperScissors.Bo:
                            return -1;
                        case RockPaperScissors.Gawi:
                            return 0;
                    }
                    break;

                default:
                    break;
            }
            return 0;
        }
    }
}//programing 할때 최대한 실수 없는 코드를 짜라. bug를 줄일 수 있다.