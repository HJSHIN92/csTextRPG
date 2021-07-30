using System;

/*
c#에서 클래스상속은 단 하나만 가능.
 */

class FightUnit
{
    //     public protected private
    //범위  외부까지  자식까지    나만
    
    protected int AT = 10;
    protected int HP = 100;

    public void Damage(FightUnit _OtherUnit)
    {
        // fightUnit 이지만 Player 기능을 쓰고싶다
        // 이럴 때 쓰는 것이 다운캐스팅,
        // But 최대한 지양!
        // 실수로 class 역할들이 뒤바뀔 수 있다.
        this.HP -= _OtherUnit.AT;
    }
}

class Player : FightUnit
{
    int Lv = 1;

    void Heal()
    {
        HP = 100;
    }
}

class Monster : FightUnit
{
    int Exp = 10;
}




namespace _23inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            Monster newMonster = new Monster();

            // 업캐스팅
            // 자식이 부모형이 되는 것.
            // 그러므로 자식에만 있는 능력을 버린다
            // (player에서는 Lv, Monster에서는 exp 각각에만 있는 변수들 못씀!)
            newPlayer.Damage(newMonster);

        }
    }
}
