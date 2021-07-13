 using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tictactest
{
    [TestClass]
    public class GameBoardSpecificattions
    {

        [TestMethod]
        public void InitBoard_FirstCharacter()
        {
            var gameBoard = new GameBoard("X");
            Assert.AreEqual("X", gameBoard[0, 0]);
        }

        [TestMethod]
        public void InitBoard_2ndCharacter()
        {
            var gameBoard = new GameBoard(" X");

            Assert.AreEqual("X", gameBoard[1, 0]);
        }

        [TestMethod]
        public void InitBoard_SetLastCharacher_ReadLastCharacter_AsExpected()
        {
            const string InitialBoardSetep = "   "
                                           + "   "
                                           + "  b";

            var gameBoard = new GameBoard(InitialBoardSetep);
            Assert.AreEqual("b", gameBoard[2, 2]);

        }
       /* [TestMethod]
        public void InitBoard_SetFirstCharacter_ReadFirstCharacter_AsExpected()
        {
            const string initialBoardSetup = "   " 
                                           + "   " 
                                           + "  X";
            var gameBoard = new GameBoard(initialBoardSetup);

            Assert.AreEqual("X", gameBoard[2, 2]);
        }
       */
    }
}
