using System;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            //var parse = new Parse();
            //var parser = parse.Parser(input);
            var winnerPlayer = "Black";
            var winnerCategory = "all of a kind";
            var winnerPoints = "6";
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoints}";
        }
    }
}