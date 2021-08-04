using System;

class Start
{
    public STARTSELECT StartSelect()
    {
        Console.Clear();
        Console.WriteLine("1. 마을");
        Console.WriteLine("2. 배틀화면");
        Console.WriteLine("어디로 가시겠습니까?");

        ConsoleKeyInfo CKI = Console.ReadKey();
        switch (CKI.Key)
        {
            case ConsoleKey.D1:
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
}