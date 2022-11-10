using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string PlayerName { get; set; }
        public Roshambo RoshamValue { get; set; }


        public abstract Roshambo GenerateRoshambo();
    }
}
