using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random rnd = new Random();

            Type type = typeof(Roshambo);
            Array roshams = type.GetEnumValues();
            int index = rnd.Next(roshams.Length);

            Roshambo rosham = (Roshambo)roshams.GetValue(index);

            return rosham;
        }
    }
}
