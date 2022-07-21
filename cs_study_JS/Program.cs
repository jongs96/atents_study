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
            //Random 함수
            //Random rnd = new Random();
            //rnd 에 랜덤번호 부여
            //삼각함수 table을 이용해 random값이 만들어짐.
            //컴퓨터 내에 저장되어 있는 pi값이 이용됨.
            //Random rnd = new Random(시드값)
            //시드값의 의미 : table에서 몇번째부터의 값을 뽑아온다는 의미
            //시드값을 설정하면 매번 실행할 때마다 같은값이 나온다.
            //시드값을 비우면 현재시간 기반으로 시드값을 설정해서 랜덤번호 생성.
            //**랜덤한 값을 뽑고나면 뽑는 위치가 이동이된다.**

            //Console.WriteLine(rnd.Next(1, 101));//rnd.Next((랜덤을생성할)첫번호, 마지막번호 +1)
            //삼각함수 랜덤값이 편중되어 있는 경우가 있어 table을 직접 만들어서 사용하기도 한다.

            //크기가 6인 배열을 만들고 1~45의 랜덤한 값으로 로또 번호를 생성 하시오.(중복 숫자가 있으면 안됨.)
            Random rnd = new Random();
            int[] Num = new int[6];
            bool check = true;
            for (int n = 0; n < Num.Length; ++n)
            {
                Num[n] = rnd.Next(1, 46);

                while (check)
                {
                    for (int n2 = 0; n2 < Num.Length; ++n2)
                    {
                        if (Num[n] == Num[n2])
                        {
                            check = false;
                            break;
                        }
                    }
                    Num[n] = rnd.Next(1, 46);
                }
            }

            foreach (int W in Num)
            {
                Console.WriteLine(W);
            }

            //강사님 답
            //Random rnd = new Random();
            //byte[] LottoNumber = new byte[6];

            //for(int i = 0; i<LottoNumber.Length;)//반복조건 유의, 증감 제거
            //{
            //    bool check = false;
            //    LottoNumber[i] = (byte)rnd.Next(1,46);// int형 rnd값 byte로 형변환.
            //    for(int n = 0; n < i; ++n)
            //    {
            //        if(LottoNumber[n]==LottoNumber[i])
            //        {
            //            //중복숫자
            //            check = true;
            //            break;
            //        }
            //    }
            //    if(!check)
            //    {
            //        ++i;
            //    }
            //}

            //foreach(int num in LottoNumber)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}