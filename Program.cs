using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MultiplayerGameLobbySystem
{
    internal class Program
    {
        static void Main()
        {
            Player p1 = new Player("jack", "diadb");
            Player p2 = new Player("jhon", "diadkwdka");
            Player p3 = new Player("lucy", "diadsfksb");
            Player p4 = new Player("kira", "dia2733db");

            GameRoom newGameRoom = new GameRoom();
            try
            {
                newGameRoom.RegisterPlayer(p1);
                newGameRoom.RegisterPlayer(p2);
                newGameRoom.RegisterPlayer(p3);
                newGameRoom.RegisterPlayer(p4);
                newGameRoom.RegisterPlayer(p1);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }

            

            newGameRoom.AddQueue(p1);
            newGameRoom.AddQueue(p2);
            newGameRoom.AddQueue(p3);
            newGameRoom.AddQueue(p2);
            newGameRoom.AddQueue(p4);
            newGameRoom.AddQueue(p3);

            newGameRoom.JoinMatch("ranked");
            newGameRoom.JoinMatch("Ranked");
            newGameRoom.JoinMatch("Ranked");



            newGameRoom.ShowHistory();
            newGameRoom.ShowLeaderBoard();

        }
    }
}

