using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeSignalR.Models
{
    internal class Player
    {
        //gets or sets player name. Set at time user registers.
        public string Name { get; set; }

        //Gets or sets the opponent player. Set when player clicks find opponent in UI.
        public Player Opponent { get; set; }

        //value indicates whether user is playing or not. Set on runtime.
        public bool IsPLaying { get; set; }

        //indicated is player is waiting on move
        public bool WaitingForMove { get; set; }

        //indicates if searn=rching for an oppoonent or not
        public bool IsSearchingOpponent { get; set; }

        //time when user registered
        public DateTime RegisterTime { get; set; }

        //display of the Character's "image" if the user chooses to do so
        public string Image { get; set; }

        //connects player with connection Id in game
        public string ConnectionId { get; set; }
    }
}
