using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplayerGameLobbySystem
{
    public class PlayerExistsException : Exception
    {
        public PlayerExistsException(string message) : base(message) 
        {
            
        }
    }

    public class PlayerDoesNotExistException : Exception
    {
        public PlayerDoesNotExistException(string message) : base(message)
        {

        }
    }

    class NotEnoughPlayersException : Exception
    {
        public NotEnoughPlayersException(string message) : base(message)
        {

        }
    }

}
