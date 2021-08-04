using System;

class C_battle
{
    public STARTSELECT Battle(Player _player)
    {
        Console.WriteLine("배틀존에 들어왔습니다");
        Monster Newmonster = new Monster("오크");
        while (false == Newmonster.IsDeath() && false == _player.IsDeath())
        {
            Console.Clear();
            _player.StatusRender();
            Newmonster.StatusRender();

            Newmonster.Damage(_player);

            if (false == Newmonster.IsDeath())
            {
                _player.Damage(Newmonster);
            }

            Console.ReadKey();
        }
        Console.WriteLine("싸움이 끝났습니다");
        if (true == Newmonster.IsDeath())
        {
            Console.WriteLine("플레이어의 승리");
        }
        else
        {
            Console.WriteLine("몬스터 승리");
        }
        Console.ReadKey();
        return STARTSELECT.SELECTTOWN;
    }
}