using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplayerGameLobbySystem
{
    public class Player
    {
        public string Nickname { get; set; }
        public int Rank { get; set; } = 0;
        private string password;
        public string Password
        {
            set
            {
                password = value;
            }
        }
        public Player(string nick,string pass)
        {
            Nickname = nick;
            Password = pass;
        }
    }
}
