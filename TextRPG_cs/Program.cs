using System;

/*
 초반 프로그램이의 전부는
1. 객체(클래스) 선언
2. 함수의 선언
3. 함수의 분기
 */

class Player
{
    int AT = 10;
    int HP = 50;
    int MAXHP = 100;

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
        if(HP >= MAXHP)
        {
            Console.WriteLine("체력이 모두 회복되어있습니다");
            Console.ReadKey();
        }else
        {
        this.HP = MAXHP;
        PrintHP();
        }
    }

    public void StatusRender()
    {
        Console.WriteLine("--------------------------");
        Console.Write("공격력 :");
        Console.WriteLine(AT);

        Console.Write("체력 :");
        Console.Write(HP);
        Console.Write(" / ");
        Console.WriteLine(MAXHP);
        Console.WriteLine("--------------------------");
    }


}

class Monster
{
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

                // 방법 1
                // ConsoleKeyInfo CKI = Console.ReadKey()
                // (CKI.Key)

                // 방법 2
                // ConsoleKey CK = Console.ReadKey().Key
                // (CK)

                // 방법 3
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

        static void Battle()
        {
            Console.WriteLine("배틀존에 들어왔습니다");
            Console.ReadKey();
        }

        // 메인함
        static void Main(string[] args)
        {
            //ConsoleKeyInfo Keyinfo = Console.ReadKey();
            //Console.WriteLine(Keyinfo.Key);
            // consolekeyInfo는 info, float같은 자료형
            // consolekeyInfo는 struct형 (정적함수, 값형)

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
                        Battle();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
