using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tictactest
{
    [TestClass]
    public class TicTacTesting
    {
        Game game = new Game();

        [TestMethod]
        public void GetWinner_MarkersTheSameIn1stRow()
        {
            const string initalBoardSetup =("XXX" +
                                            "   " +
                                            "   ");
            this.game = new Game(initalBoardSetup);
             
            Assert.IsTrue(this.game.GetWinner() == "X");
        }

        [TestMethod]
        public void GetWinner_MarkersTheSameIn2ndRow()
        {
            const string initialBoardSetup = ("   " +
                                              "XXX" +
                                              "   ");

            this.game = new Game(initialBoardSetup);

            Assert.AreEqual("X", this.game.GetWinner());

        }

        [TestMethod]
        public void GetWinner_MarkersTheSameIn3rdRow()
        {
            const string initialBoardSetup= ("   " +
                                             "   " +
                                             "XXX");

            this.game = new Game(initialBoardSetup);

            Assert.IsTrue(this.game.GetWinner() == "X");

        }

        public void GetWinnerMarkersTheSameIn3rdRow_WithO()
        {
            const string initialBoardSetup = "   " +
                                             "   " +
                                             "OOO";

            this.game = new Game(initialBoardSetup);
            Assert.IsTrue(this.game.GetWinner() == "O");

        }
        [TestMethod]
        public void Example_P1Wins_AllMarkersIn1Row()
        {
           
            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("O", 0, 1);
            game.Play("X", 1, 0);
            game.Play("O", 2, 1);
            game.Play("X", 2, 0);

            Assert.IsTrue(game.GetWinner() == "X");
        }

        [TestMethod]
        public void Example_P2Wins_AllMarkersIn1Row()
        {
            Game game = new Game();
            game.Play("X", 2, 1);
            game.Play("O", 0, 0);
            game.Play("X", 1, 1);
            game.Play("O", 0, 1);
            game.Play("X", 2, 2);
            game.Play("O", 0, 2);

            Assert.IsTrue(game.GetWinner() == "O");
   
        }

        [TestMethod]
        public void GetWinner_MarkersDiagonal()
        {
            this.game = new Game("X  "+
                                 " X "+
                                 "  X");

            Assert.IsTrue(game.GetWinner() == "X");
        }

        [TestMethod]
        public void GetWinner_MarkersOtherDiagonal()
        {
            this.game = new Game("  X" +
                                 " X " +
                                 "X  ");

            Assert.IsTrue(game.GetWinner() == "X");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MarkerAlreadyMarked_Exception()
        {
            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("O", 0, 0);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SamePlayerPlaysTwice_Exception ()
        {
            Game game = new Game();
            game.Play("X", 0, 0);
            game.Play("X", 1, 0);

        }

        [TestMethod]
        public void NoWinnerYet()
        {
            game.Play("X", 2, 1);
            Assert.IsTrue(game.GetWinner() == string.Empty);
        }

    }
}
