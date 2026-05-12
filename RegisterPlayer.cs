using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplayerGameLobbySystem
{
    public class RegisterPlayer
    {

        public List<Player> players = new List<Player>();
        public void Register(Player player)
        {
            players.Add(player);
        }
        
    }
}
