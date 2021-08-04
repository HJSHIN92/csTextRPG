using System;

namespace TextRPG_cs
{
    class Program
    {
            static void Main(string[] args)
        {
            Player newPlayer = new Player();
            C_Town newTown = new C_Town();
            C_battle newBattel = new C_battle();
            Start newStart = new Start();


            STARTSELECT SelectCheck = STARTSELECT.SELECTNONE;
            while (true)
            {
                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTNONE:
                        SelectCheck = newStart.StartSelect();
                        break;
                    case STARTSELECT.SELECTTOWN:
                        SelectCheck = newTown.Town(newPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        SelectCheck = newBattel.Battle(newPlayer);
                        break;
                    default:
                        break;
                }               
            }
        }
    }
}
