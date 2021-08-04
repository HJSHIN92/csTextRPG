using System;

enum DMGTYPE
{
FIREDMG,
ICEDMG,
PYDMG
}


class Player
{
    static void fun10(int _value)
    {
    }

    static void fun11(float _value)
    {
    }

    int FireDef = 5;
    int IceDef = 5;
    int AttDef = 5;
    int HP = 10;
    // 함수 오버로딩
    // 컴퓨터가 인식하는 함수이름은 다르다.
    // Damage int
    public void Damage(int _Damage)
    {

    }

    // Damage float
    public void Damage(float _Damage)
    {

    }

    // Damage int int
    public void Damage(int _Damage, DMGTYPE _TYPE)
    {
        switch(_TYPE)
        {
            case DMGTYPE.FIREDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.PYDMG:
                _Damage -= IceDef;
                break;
        }
        // 오버로딩함수를 함수안에 써준다.
        Damage(_Damage);
    }

    public Player(int _Hp)
    {
        HP = _Hp;
    }
}

namespace _28overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player(100);
            newPlayer.Damage(100, DMGTYPE.FIREDMG);

        }
    }
}
