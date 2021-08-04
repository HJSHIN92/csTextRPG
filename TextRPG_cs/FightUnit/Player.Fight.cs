using System;

partial class Player : FightUnit
{
    public void PrintHP()
    {
        Console.Write("현재 플레이어의 HP는");
        Console.Write(HP);
        Console.Write(" / ");
        Console.Write(MAXHP);
        Console.Write("입니다");
    }

    public void MaxHeal(/* Player this*/)
    {
        if (HP >= MAXHP)
        {
            Console.WriteLine("체력이 모두 회복되어있습니다");
            Console.ReadKey();
        }
        else
        {
            this.HP = MAXHP;
            PrintHP();
        }
    }

}