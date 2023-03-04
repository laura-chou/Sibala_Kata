using System;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var winnerPlayer = "Black";
            var winnerCategory = "all of a kind";
            var winnerPoint = "6";
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}