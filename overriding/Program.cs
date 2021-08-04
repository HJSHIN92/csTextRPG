using System;

class FightUnit
{
    protected string Name = "none";
    protected int AT =10;
    protected int HP = 100;


    /*
     이 문법의 핵심은
    자식에서 만약 부모의 GetAT를 재구현했다면
    자식의 형태의 GetAT를 호출하는 것,
    이것이 오버라이딩이다.

    다형성(동적바인딩)의 핵심 문법 중 하나이다.
     */

    public virtual int GetAT()
    {
        Console.WriteLine("FightUnit의 GetAT");
        return AT;
    }

    public void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.GetAT();
        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "만큼의 데미지를 입었습니다");
        HP -= AT;
    }

}

class Player : FightUnit
{

    int ItemAT = 5;

    public Player(string _Name)
    {
        Name = _Name;
    }
    // override
    // 나는 부모class의 GetAt를 재구현했다는 
    public override int GetAT()
    {
        Console.WriteLine("Player의 GetAT");
        return AT + ItemAT;
    }
}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public override int GetAT()
    {
        return AT + MonsterLv;
    }

    public Monster(string _Name)
    {
        Name = _Name;
    }
}

namespace overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player("플레이어");
            Monster newMonster = new Monster("몬스터");
 
            newPlayer.Damage(newMonster);
            newMonster.Damage(newPlayer);
        }
    }
}
