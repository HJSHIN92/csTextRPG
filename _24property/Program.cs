using System;

class Player
{
    // 보통 어떤 멤버변수가 타겟이다.
    int AT = 10;

    // 정적프로퍼티
    static int m_StaticValue = 100;
    // 정적멤버변수와 (일반적인) 멤버변수 차이
    // 사용법은 비슷, 문법만 조금 다를 뿐이다.
    // static 변수  : 객체이름으로 쓴다.
    // (일반)멤버변수 : 클래스이름으로 쓴다.

    public static int StaticValue
    {
        get
        {
            return m_StaticValue;
        }

        set
        {
            m_StaticValue = value ;
        }
    }

    // 자료형을 선언했다면 이는 int와 관련된 함수라고 명시r
    public int ProAT
    {
        // 프로퍼티 get 함수는 무조건 int 리턴
        get
        {
            return AT;
        }

        // 무조건 int 하나가 들어온다고 생각한다.
        // 그런 외부값들을
        // 프로퍼티에서는 value라고 기호로 정의해놈.
        set
        {
            AT = value;
        }
    }

    public int GetAT()
    {
        return AT;
    }

    public void SetAT(int _Value)
    {
        if(999 < AT)
        {
            Console.WriteLine("최대치 이상이 될 수 없습니다.");
            // 아예 멈춰버림. 그렇게 좋은 방법은 아니다.
            //while(true)
            //{
            //    Console.ReadKey();
            //}
        }
        AT = _Value;
    }
}

namespace _24property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();

            Player.StaticValue = 200;

            newPlayer.ProAT = 100;
            int PlayerAT = newPlayer.ProAT;
        }
    }
}
