using System;

class FightUnit
{
    protected int AT;

    public FightUnit()
    {
        
    }
}

class Player
{
// 생성자
// 함수랑 비슷함
// return 값이 없음.
// 생성자란 "메모리가 만들어질 때" 한 번 실행(호출)됨.
// 눈에 보이지않지만 만들지 않아도 만들어짐.

    public Player()
    {

    }
}

namespace ClassConstructer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 생성될 때 함께 적용되게 하고싶은 항목을 넣어준다.
            Player newPlayer = new Player();
        }
    }
}
