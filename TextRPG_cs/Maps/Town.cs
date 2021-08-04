using System;

class C_Town
{ 
    public STARTSELECT Town(Player _player)
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
                    return STARTSELECT.SELECTNONE;
            }
        }
    }
}

