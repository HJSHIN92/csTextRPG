using System;

/*
사용자 정의 자료형인데,
선언만 가능
정의불가
public만 가
 */

// 함수의 형태만 물려줄 수 있는 문법.
interface QuestUnit
{
    void Talk(QuestUnit _OtherUnit);
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {
    }
}

/* 인터페이스는 함수구현을 강제할 수 있다.
 * 
 */
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class Monster : FightUnit
{
}

class NPC : FightUnit, QuestUnit
{

    public void Talk(QuestUnit _OtherUnit)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player newPlayer = new Player();
        NPC newNPC = new NPC();

        QuestUnit NewQuestUnit = new NPC();
        // 업캐스팅이 된다.

        newPlayer.Talk(newNPC);
        newNPC.Talk(newPlayer);
       
    }
}
