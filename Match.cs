using MultiplayerGameLobbySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MultiplayerGameLobbySystem
{
    public class MatchGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public MatchGame(Player p1, Player p2)
        {
            Player1 = p1;
            Player2 = p2;
        }
        public virtual void Start() { }
        public virtual void End() { }
        public virtual void GamePlay() { }

    }
}



