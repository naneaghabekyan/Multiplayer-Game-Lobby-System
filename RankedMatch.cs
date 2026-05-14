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

    public class RankedMatch : MatchGame
    {
        public RankedMatch(Player p1, Player p2)
        : base(p1, p2)
        {
        }
        public override void Start()
        {
            Console.WriteLine($"{Player1.Nickname} and {Player2.Nickname} started a ranked match!\n ");
        }

        public override void GamePlay()
        {
            Game newGame = new Game();

            (newGame.GameLogic(Player1, Player2)).Rank += 80;
        }

        public override void End()
        {
            Console.WriteLine($"{Player1.Nickname} and {Player2.Nickname} finished the ranked match!\n ");
            Console.WriteLine($"Ranks:\n {Player1.Nickname}: {Player1.Rank}\n {Player2.Nickname}: {Player2.Rank}");
        }
    }
}