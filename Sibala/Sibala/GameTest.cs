﻿using FluentAssertions;
using NUnit.Framework;

namespace Sibala
{
    [TestFixture]
    public class GameTest
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        [TestCase("Black: 6 6 6 6  White: 3 3 3 3", "Black win. - with all of a kind: 6")]
        [TestCase("Black: 2 2 2 2  White: 5 5 5 5", "White win. - with all of a kind: 5")]
        public void A01_BothAllOfKind(string input, string expected)
        {
            var actual = _game.ShowResult(input);
            actual.Should().Be(expected);
        }
    }
}
