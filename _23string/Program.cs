using System;

//

namespace _23string
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string은 동적 기본자료형
            string = char의 집합
            자료형 자체가 c#에서 만들어놓은 기본구조체
             */
            int AAA = new int();
            AAA = 100;

            /*
             int는 구조체고 내부의 멤버변수나 함수가 존재한다.
            그것을 통해서 문자열로 변환해줄 수 있다.
             */

            string Left = "안녕하세요";
            string right = " 날씨가 좋아요";
            string result = Left + right + AAA.ToString();

            Console.WriteLine(result);
        }
    }
}
