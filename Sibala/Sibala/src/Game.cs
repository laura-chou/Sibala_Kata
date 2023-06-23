using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala.src
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parser = new Parser();
            var parse = parser.Parse(input);

            var player1Dices = parse[0].Dices;
            var player2Dices = parse[1].Dices;

            var comparer = new AllOfKindComparer();
            int compareResult = comparer.Compare(player1Dices, player2Dices, out var winnerPoint);
            
            if (compareResult != 0)
            {
                var winnerPlayer = compareResult > 0 ? parse[0].Name : parse[1].Name;
                var winnerCategory = "all of a kind";
                return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
            }

            return "Tie";
        }
    }
}
