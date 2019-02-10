﻿using System;
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
    }
}
