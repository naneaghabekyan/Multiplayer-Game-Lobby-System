using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MultiplayerGameLobbySystem;

namespace MultiplayerGameLobbySystem
{
    public class MatchGame
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public MatchGame(Player p1,Player p2)
        {
            Player1 = p1;
            Player2 = p2;
        }
        public virtual void Start() { }
        public virtual void End() { }
        

    }
}

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
        
        public override void End()
        {
            Console.WriteLine($"{Player1.Nickname} and {Player2.Nickname} finished the ranked match!\n ");
        }
    }

public class CasualMatch : MatchGame
{
    public CasualMatch(Player p1, Player p2)
    : base(p1, p2)
    {
    }
    public override void Start()
    {
        Console.WriteLine($"{Player1.Nickname} and {Player2.Nickname} started a casual match!\n ");
    }
    public override void End()
    {
        Console.WriteLine($"{Player1.Nickname} and {Player2.Nickname} finished the casual match!\n ");
    }
}