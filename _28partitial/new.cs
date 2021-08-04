using System;

namespace _31Array
{
    class Program
    {
        class Item
        {
            public string Name = "none";
            public int AT = 10;
            public int HP = 100;
        }
        static void Main(string[] args)
        {
            /*
             * 배열은 기본적으로 자료형이며, 기본자료형
             * 선언 방식 : 자료형[]
             * 모든 자료형은 구조체 아니면 클래스에 가까움
             * 기본자료형도 마찬가지임
             * 
             */
            int[] ArrInt = new int[10];
            // int가 10개생겼다.

            float[] Arrfloat = new float[10];

            // 정수형 short
            // int64
            // ArrInt는 int의 배열형(int의 집합)
            // ArrInt[0]은 무슨 자료형인가?

            // C#에서는 모든 자료형은 클래스 혹은 구조체
            // 멤버변수, 멤버함수

            for(int i = 0; i < ArrInt.Length; i++)
            {
                Console.WriteLine(ArrInt[i]);
            }

            // 배열은 언제 사용하는가?
            // 아이템이 100개있다고 가정.

            // 아이템이라는 참조형을
            // 담을 수 있는 공간이 10개 생겼다.

            // 아이템이라는 메모리를 가리킬 수 있는
            // 참조형이 10개 생겼다.
            Item[] ArrItem = new Item[10];


            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "나무막대";

            for (int i =0; i < ArrItem.Length; i++)
            {
                ArrItem[i] = new Item();
                Console.WriteLine(ArrInt[i]);

            }

            //int Value = ArrInt[0];
            //Console.WriteLine(ArrInt[0]);

        }
    }
}
