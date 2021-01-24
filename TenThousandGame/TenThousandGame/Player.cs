using System;
using System.Collections.Generic;
using System.Text;

namespace TenThousandGame
{
    public class Player
    {
        Player()
        {
            Score = 0;
           var Die = new Die();
        }
        public string Name { get; set; }
        public int Score { get; set; }
        public List<Die> Hand { get; set; }

        public List<Die> roll(List<Die> hand)
        {
            Random rand = new Random();
            
            foreach (Die die in hand)
            {
                die.value = rand.Next(1, die.sides);
            }
            return hand;
        }
    }
}
