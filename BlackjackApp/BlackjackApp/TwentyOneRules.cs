using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackApp
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()  //create a dictionary for card values. 
        {                                                                               //Enums alone wouldn't work because they have to have unique int values.
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1,
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)     // checks for the number of aces in player's hand, aces can be 1 or 11.
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);             
            int[] result = new int[aceCount + 1];                          // length of list is aceCount + 1, because if no aces exist, then there needs to be one place for the value of the hand to exist 
            int value = Hand.Sum( x => _cardValues[x.Face]);               // gets the value. aces are worth 1 by default, so this is the minimum value             
            result[0] = value;                                             //sets the first list item to the minimum value
            if (result.Length == 1)                                        //if there were no aces, the length will be one, and there is only 1 possible result, so we break out of the loop.
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)                         //we start iterating on the 2nd list position
            {
                value += (i * 10);                                          //add 10 for first ace, set result in list, add 20 for if both aces were 11. if hand for example were 2,A,A, our list would be [4, 14, 24]
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool shouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                } 
            }
            return false; 
        }
    }
}