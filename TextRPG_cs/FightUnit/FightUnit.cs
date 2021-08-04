using System;

class FightUnit
{
    protected string name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int MAXHP = 100;

    public bool IsDeath()
    {
        // A = 100
        // 100 = A
        // bool boolDeath = HP <= 0;
        // 연산자도 함수에 가깝
        return HP <= 0;
    }

    public void StatusRender()
    {
        Console.WriteLine(name + "의 능력치--------------------------");
        Console.WriteLine("공격력 :" + AT);

        Console.WriteLine("체력 :" + HP + "/" + MAXHP);
        Console.WriteLine("--------------------------");
    }

    public void Damage(FightUnit _OtherUnit)
    {
        Console.WriteLine(name + "가" + _OtherUnit.AT + "의 데미지를 입었습니다");
        Console.ReadKey();
        HP -= _OtherUnit.AT;
    }

}