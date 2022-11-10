using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class HumanPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            try
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "rock":
                    case "r":
                        return Roshambo.Rock;

                    case "paper":
                    case "p":
                        return Roshambo.Paper;

                    case "scissors":
                    case "s":
                        return Roshambo.Scissors;
                    default:
                        return Roshambo.Scissors;

                }
            }
            catch (Exception)
            {

                return Roshambo.Rock;
            }

        }
    }
}
