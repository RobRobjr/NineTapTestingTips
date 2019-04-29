using Microsoft.VisualStudio.TestTools.UnitTesting;
using NineTapTestingTips;
using System;

namespace NineTapTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        [DataRow((short)0)]
        [DataRow((short)99)]
        [DataRow((short)150)]
        [DataRow((short)300)]
        public void Game1_SetValidScore_UpdatesScore( short score )
        {
            //Arrange
            Game g = new Game();
            //Act
            g.Game1 = score;
            //Assert
            Assert.AreEqual(score, g.Game1);
        }

        [TestMethod]
        [DataRow((short)-1)]
        [DataRow((short)-1000)]
        [DataRow(short.MinValue)]
        [DataRow((short)301)]
        [DataRow((short)3000)]
        [DataRow(short.MaxValue)]
        public void Game1_InvalidScore_ThrowsArguementException( short score )
        {
            Game g = new Game();
            //g.Game1 = score; wrong way to do this, because it doesn't check for an exception
            Assert.ThrowsException<ArgumentException>( () => g.Game1 = score );
        }

        [TestMethod]
        public void UpdateGameScoreProperties_UpdatesTotalScore()
        {
            Game g = new Game();
            g.Game1 = 200;
            g.Game2 = 200;
            g.Game3 = 150;
            g.Game4 = 150;

            short expectedTotalScore = 700;
            Assert.AreEqual(expectedTotalScore, g.TotalScore);

            g.Game3 = 100;
            short newExpectTotalScore = 650;
            Assert.AreEqual(newExpectTotalScore, g.TotalScore);
        }
    }
}
