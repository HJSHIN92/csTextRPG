using System;

/*
 초반 프로그램이의 전부는
1. 객체(클래스) 선언
2. 함수의 선언
3. 함수의 분기
 */

class FightUnit
{
    protected string name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int MAXHP = 100;

    public void StatusRender()
    {
        Console.Write(name);
        Console.WriteLine("의 능력치--------------------------");
        Console.Write("공격력 :");
        Console.WriteLine(AT);

        Console.Write("체력 :");
        Console.Write(HP);
        Console.Write(" / ");
        Console.WriteLine(MAXHP);
        Console.WriteLine("--------------------------");
    }

    public void BattlePVE(FightUnit _unitA, FightUnit _unitB)
    {
        //bool isdead = false;

        Console.WriteLine(_unitA + "가 " + _unitB + "에게 " + _unitA.AT + "만큼의 피해를 입혔습니다");
        Console.Write(_unitB.HP);
        _unitB.HP -= _unitA.AT;
        Console.WriteLine(" => " + _unitB.HP);
        Console.ReadKey();
        Console.WriteLine(_unitB + "가 " + _unitA + "에게 " + _unitB.AT + "만큼의 피해를 입혔습니다");
        Console.Write(_unitA.HP);
        _unitA.HP -= _unitB.AT;
        Console.WriteLine(" => " + _unitA.HP);
        Console.ReadKey();

        //if (_unitA.HP <= 0)
        //{
        //    Console.WriteLine("플레이어가 패망했습니다");
        //    return;
        //isDead = true;
        //}


    }

    public void isDead(FightUnit _unitA, FightUnit _unitB)
    {
        //bool isDead = false;
        if (_unitA.HP <= 0 || _unitB.HP <= 0)
        {
            Console.WriteLine("둘중 하나가 사망했습니다. 마을로 이동합니다.");
            //isDead = true;
            return;
        }
    }
}

class Player : FightUnit
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

    public Player()
    {
        name = "플레이어";
        HP = 100;
        AT = 20;
    }

}

class Monster : FightUnit
{
    public Monster(string _name)
    {
        name = _name;
        HP = 50;
        AT = 10;
    }
}

enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    SELECTNONE
}

namespace TextRPG_cs
{
    class Program
    {
        // 시작하는 함수. (마을 or 싸움터)
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀화면");
            Console.WriteLine("어디로 가시겠습니까?");

            ConsoleKeyInfo CKI = Console.ReadKey();
            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    //break;
                    Console.WriteLine("마을로 이동합니다");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("배틀을 시작합니다");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다");
                    return STARTSELECT.SELECTNONE;

            }
        }

        static void Town(Player _player)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                Console.WriteLine("마을에서 무엇을 할까요?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _player.MaxHeal();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        static void Battle(Player _player)
        {
            Console.WriteLine("배틀존에 들어왔습니다");


            Monster Newmonster = new Monster("오크");
            // 숙제
            // 1. 둘중 누가 죽을 때까지 싸우기
            // 1-1. 플레이어한대 몬스터한ㄷ
            // 2. 한쪽이 주그면(나간다) 마을로 자동이송
            // 2-1. 그냥나간다
            // 2-2. 마을로 나간다
            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                Newmonster.StatusRender();
                Console.WriteLine("1. 공격한다");
                Console.WriteLine("2. 마을로 도망간다");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("플레이어의 공격!");
                        _player.BattlePVE(_player, Newmonster);
                        _player.isDead(_player, Newmonster);
                        break;
                    case ConsoleKey.D2:
                        return;
                }
            }
        }

        // 메인함
        static void Main(string[] args)
        {
            Player newPlayer = new Player();

            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(newPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(newPlayer);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
