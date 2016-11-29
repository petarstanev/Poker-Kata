using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class TestPokerScorer
    {
        [TestMethod]
        public void ItShouldMarkAPairOfEightsBetterThanAPairOfFives()
        {
            //Given
            string input = "5H 5C 6S 7S KD 2C 3S 8S 8D TD";

            //When
            var scorer = new PokerScorer();
            var result = scorer.Player1Won(input);

            //Then
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ItShouldMarkAPairOfEightsBetterHigherCard()
        {
            //Given
            string input = "5H 5C 6S 7S KD 2C 3S 5S 8D TD";

            //When
            var scorer = new PokerScorer();
            var result = scorer.Player1Won(input);

            //Then
            Assert.IsFalse(result);
        }
    }
}