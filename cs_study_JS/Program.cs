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
            //과제 : 1~10사이의 숫자를 입력받아 *로 삼각형을 만드세요.
            Console.WriteLine("1~10사이의 정수를 입력하시오.");
            string Input = Console.ReadLine();
            int Num = int.Parse(Input);

            string temp = "";

            for(int i = Num; i>0; --i)
            {
                temp = "";
                for(int j = i; j>0; --j)
                {
                    temp += "*";
                }
                Console.WriteLine(temp);
            }            
        }
    }
}