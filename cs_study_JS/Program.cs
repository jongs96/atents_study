using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_study_JS
{
    class Program
    {
        static void Main(string[] args)
        {
            //네자리의 숫자를 입력받고 입력받은 숫자를 한글로 출력하세요.
            //4321->사삼이일

            //Console.WriteLine("네 자리의 숫자를 입력하시오.");
            //int Num = int.Parse(Console.ReadLine());//문자를 변형하는 경우라.int.Parse이고 비슷한 자료형변환은 (변환자료형)으로가능
            //string temp = "";
            //int[] n = new int[4];

            //for (int i = 0; i < n.Length; i++)
            //{
            //    n[i] = Num % 10;
            //    Num /= 10;
            //}

            //for (int i = 3; i >= 0; --i)
            //{
            //    switch (n[i])
            //    {
            //        case 0:
            //            temp += "영";
            //            break;
            //        case 1:
            //            temp += "일";
            //            break;
            //        case 2:
            //            temp += "이";
            //            break;
            //        case 3:
            //            temp += "삼";
            //            break;
            //        case 4:
            //            temp += "사";
            //            break;
            //        case 5:
            //            temp += "오";
            //            break;
            //        case 6:
            //            temp += "육";
            //            break;
            //        case 7:
            //            temp += "칠";
            //            break;
            //        case 8:
            //            temp += "팔";
            //            break;
            //        case 9:
            //            temp += "구";
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //Console.WriteLine(temp);

            //강사님 코드
            int Num = int.Parse(Console.ReadLine());
            int[] Numlist = new int[4];
            int i = 0;

            while(Num > 0)
            {
                Numlist[i] = Num % 10;
                Num /= 10;
                ++i;
            }

            for(i = Numlist.Length -1; i>=0; --i)
            {
                switch(Numlist[i])
                {
                    case 0:
                        Console.WriteLine("영");
                        break;
                    case 1:
                        Console.WriteLine("일");
                        break;
                    case 2:
                        Console.WriteLine("이");
                        break;
                    case 3:
                        Console.WriteLine("삼");
                        break;
                    case 4:
                        Console.WriteLine("사");
                        break;
                    case 5:
                        Console.WriteLine("오");
                        break;
                    case 6:
                        Console.WriteLine("육");
                        break;
                    case 7:
                        Console.WriteLine("칠");
                        break;
                    case 8:
                        Console.WriteLine("팔");
                        break;
                    case 9:
                        Console.WriteLine("구");
                        break;
                }
            }
        }
    }
}